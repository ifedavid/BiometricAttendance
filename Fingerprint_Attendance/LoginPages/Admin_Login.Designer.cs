namespace Fingerprint_Attendance
{
    partial class Admin_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Admin_Psswrd_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_UsrNm_txt = new System.Windows.Forms.TextBox();
            this.Admin_Login_btn = new System.Windows.Forms.Button();
            this.Admin_Cancel_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Admin_Psswrd_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Admin_UsrNm_txt);
            this.panel1.Location = new System.Drawing.Point(27, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 140);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Admin_Psswrd_txt
            // 
            this.Admin_Psswrd_txt.Location = new System.Drawing.Point(160, 94);
            this.Admin_Psswrd_txt.Name = "Admin_Psswrd_txt";
            this.Admin_Psswrd_txt.Size = new System.Drawing.Size(100, 20);
            this.Admin_Psswrd_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // Admin_UsrNm_txt
            // 
            this.Admin_UsrNm_txt.Location = new System.Drawing.Point(160, 20);
            this.Admin_UsrNm_txt.Name = "Admin_UsrNm_txt";
            this.Admin_UsrNm_txt.Size = new System.Drawing.Size(100, 20);
            this.Admin_UsrNm_txt.TabIndex = 2;
            // 
            // Admin_Login_btn
            // 
            this.Admin_Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Login_btn.Location = new System.Drawing.Point(55, 208);
            this.Admin_Login_btn.Name = "Admin_Login_btn";
            this.Admin_Login_btn.Size = new System.Drawing.Size(113, 25);
            this.Admin_Login_btn.TabIndex = 0;
            this.Admin_Login_btn.Text = "Login";
            this.Admin_Login_btn.UseVisualStyleBackColor = true;
            this.Admin_Login_btn.Click += new System.EventHandler(this.Admin_Login_btn_Click);
            // 
            // Admin_Cancel_btn
            // 
            this.Admin_Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Cancel_btn.Location = new System.Drawing.Point(218, 208);
            this.Admin_Cancel_btn.Name = "Admin_Cancel_btn";
            this.Admin_Cancel_btn.Size = new System.Drawing.Size(106, 23);
            this.Admin_Cancel_btn.TabIndex = 0;
            this.Admin_Cancel_btn.Text = "Cancel";
            this.Admin_Cancel_btn.UseVisualStyleBackColor = true;
            this.Admin_Cancel_btn.Click += new System.EventHandler(this.Admin_Cancel_btn_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.Admin_Cancel_btn);
            this.Controls.Add(this.Admin_Login_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Login";
            this.Text = "Admin_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Admin_Psswrd_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Admin_UsrNm_txt;
        private System.Windows.Forms.Button Admin_Login_btn;
        private System.Windows.Forms.Button Admin_Cancel_btn;
    }
}