namespace LAB02
{
    partial class Bai3
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
            this.btnRead = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtCalScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(302, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(123, 53);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.Location = new System.Drawing.Point(79, 80);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(575, 114);
            this.txtScreen.TabIndex = 1;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(306, 222);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(119, 53);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click_1);
            // 
            // txtCalScreen
            // 
            this.txtCalScreen.Location = new System.Drawing.Point(93, 281);
            this.txtCalScreen.Multiline = true;
            this.txtCalScreen.Name = "txtCalScreen";
            this.txtCalScreen.Size = new System.Drawing.Size(575, 114);
            this.txtCalScreen.TabIndex = 3;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCalScreen);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtCalScreen;
    }
}