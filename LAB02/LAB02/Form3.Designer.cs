namespace LAB02
{
    partial class Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtLinecount = new System.Windows.Forms.TextBox();
            this.txtWordscount = new System.Windows.Forms.TextBox();
            this.txtCharactercount = new System.Windows.Forms.TextBox();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRead.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(33, 25);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(422, 58);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read From File";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Words Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(28, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Character Count";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFilename.Location = new System.Drawing.Point(214, 160);
            this.txtFilename.Multiline = true;
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(241, 33);
            this.txtFilename.TabIndex = 7;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSize.Location = new System.Drawing.Point(214, 222);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(111, 33);
            this.txtSize.TabIndex = 8;
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUrl.Location = new System.Drawing.Point(214, 284);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(322, 33);
            this.txtUrl.TabIndex = 9;
            // 
            // txtLinecount
            // 
            this.txtLinecount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLinecount.Location = new System.Drawing.Point(214, 345);
            this.txtLinecount.Multiline = true;
            this.txtLinecount.Name = "txtLinecount";
            this.txtLinecount.Size = new System.Drawing.Size(111, 33);
            this.txtLinecount.TabIndex = 10;
            // 
            // txtWordscount
            // 
            this.txtWordscount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtWordscount.Location = new System.Drawing.Point(214, 409);
            this.txtWordscount.Multiline = true;
            this.txtWordscount.Name = "txtWordscount";
            this.txtWordscount.Size = new System.Drawing.Size(111, 33);
            this.txtWordscount.TabIndex = 11;
            // 
            // txtCharactercount
            // 
            this.txtCharactercount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCharactercount.Location = new System.Drawing.Point(214, 465);
            this.txtCharactercount.Multiline = true;
            this.txtCharactercount.Name = "txtCharactercount";
            this.txtCharactercount.Size = new System.Drawing.Size(111, 33);
            this.txtCharactercount.TabIndex = 12;
            // 
            // txtScreen
            // 
            this.txtScreen.Location = new System.Drawing.Point(542, 25);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(478, 635);
            this.txtScreen.TabIndex = 13;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 672);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.txtCharactercount);
            this.Controls.Add(this.txtWordscount);
            this.Controls.Add(this.txtLinecount);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtLinecount;
        private System.Windows.Forms.TextBox txtWordscount;
        private System.Windows.Forms.TextBox txtCharactercount;
        private System.Windows.Forms.TextBox txtScreen;
    }
}