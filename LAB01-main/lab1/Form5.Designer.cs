namespace lab1
{
    partial class Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.ComboBox();
            this.need = new System.Windows.Forms.TextBox();
            this.done = new System.Windows.Forms.TextBox();
            this.quydoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền cần đổi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(75, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền đã đổi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(75, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tỷ giá quy đổi:";
            // 
            // Choose
            // 
            this.Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose.FormattingEnabled = true;
            this.Choose.IntegralHeight = false;
            this.Choose.Items.AddRange(new object[] {
            "USD ",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.Choose.Location = new System.Drawing.Point(481, 70);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(200, 37);
            this.Choose.TabIndex = 3;
            // 
            // need
            // 
            this.need.Location = new System.Drawing.Point(221, 70);
            this.need.Multiline = true;
            this.need.Name = "need";
            this.need.Size = new System.Drawing.Size(228, 44);
            this.need.TabIndex = 4;
            this.need.TextChanged += new System.EventHandler(this.need_TextChanged);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(263, 294);
            this.done.Multiline = true;
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(261, 45);
            this.done.TabIndex = 5;
            // 
            // quydoi
            // 
            this.quydoi.BackColor = System.Drawing.SystemColors.Control;
            this.quydoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quydoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.quydoi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.quydoi.Location = new System.Drawing.Point(275, 368);
            this.quydoi.Multiline = true;
            this.quydoi.Name = "quydoi";
            this.quydoi.Size = new System.Drawing.Size(261, 35);
            this.quydoi.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Chuyển đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(451, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quydoi);
            this.Controls.Add(this.done);
            this.Controls.Add(this.need);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Choose;
        private System.Windows.Forms.TextBox need;
        private System.Windows.Forms.TextBox done;
        private System.Windows.Forms.TextBox quydoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}