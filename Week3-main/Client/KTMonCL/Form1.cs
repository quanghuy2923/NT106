using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace KTMonCL
{
    public partial class Form1 : Form
    {
        
        private Socket client;
        byte[] buff = new byte[1024];
        byte[] buff2 = new byte[1024];

        private delegate void updateUI(string massage);
        private updateUI updateUi;
        public Form1()
        {
            InitializeComponent();
            updateUi = new updateUI(update);
            CheckForIllegalCrossThreadCalls = false;
        }
        private void update(string m)
        {
            lbHienThi.Items.Add(m);
        }
        private void startClient()
        {
            EndPoint ep = new IPEndPoint(IPAddress.Parse(txtIP.Text), Int32.Parse(txtPort.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            updateUi("Đang kết nối tới server...");
            client.BeginConnect(ep, new AsyncCallback(beginConnect), client);
        }
        private void beginConnect(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            s.EndConnect(ar);
            updateUi("Đã nhận kết nối từ server " + s.RemoteEndPoint.ToString());
            string wc = "Xin chao server!...";
            buff2 = Encoding.ASCII.GetBytes(wc);
            client.BeginSend(buff2, 0, buff2.Length, SocketFlags.None, new AsyncCallback(sendata), client);
            
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }
        private void sendata(IAsyncResult ia)
        {
           client.EndSend(ia);
        }
        private void beginReceive(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            int recv = 0;
            recv = s.EndReceive(ia);
            btnDisconnect.Enabled = true;
            string recvei = Encoding.ASCII.GetString(buff, 0, recv);
            updateUi("Server: " + recvei);
            if (recvei.ToUpper() == "")
            {
                updateUi("Ngắt kết nối với server ");
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            buff = new byte[1024];
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            startClient();
            txtSend.Focus();
        }
        private void send()
        {
            string wc = txtSend.Text;
            byte[] gui= new byte[1024];
            gui = Encoding.ASCII.GetBytes(wc);
            txtSend.Clear();
            updateUi("Client: " + wc);
            client.BeginSend(gui, 0, gui.Length, SocketFlags.None, new AsyncCallback(sendata), client);
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            send();
            txtSend.Focus();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            updateUi("Ngắt kết nối với server");
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            this.Close();
        }

        private void txtPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startClient();

            }
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();

            }
        }
    }
}
