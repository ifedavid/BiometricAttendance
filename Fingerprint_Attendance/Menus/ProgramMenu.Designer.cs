namespace Fingerprint_Attendance
{
    partial class ProgramMenu
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
            this.Admin_sub_btn = new System.Windows.Forms.Button();
            this.Lecturer_sub_btn = new System.Windows.Forms.Button();
            this.Student_sub_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_sub_btn
            // 
            this.Admin_sub_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Admin_sub_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_sub_btn.Location = new System.Drawing.Point(183, 12);
            this.Admin_sub_btn.Name = "Admin_sub_btn";
            this.Admin_sub_btn.Size = new System.Drawing.Size(226, 202);
            this.Admin_sub_btn.TabIndex = 0;
            this.Admin_sub_btn.Text = "Admin Login";
            this.Admin_sub_btn.UseVisualStyleBackColor = false;
            this.Admin_sub_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lecturer_sub_btn
            // 
            this.Lecturer_sub_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Lecturer_sub_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer_sub_btn.Location = new System.Drawing.Point(24, 246);
            this.Lecturer_sub_btn.Name = "Lecturer_sub_btn";
            this.Lecturer_sub_btn.Size = new System.Drawing.Size(204, 184);
            this.Lecturer_sub_btn.TabIndex = 1;
            this.Lecturer_sub_btn.Text = "Lecturer Activator Setup";
            this.Lecturer_sub_btn.UseVisualStyleBackColor = false;
            this.Lecturer_sub_btn.Click += new System.EventHandler(this.Lecturer_sub_btn_Click);
            // 
            // Student_sub_btn
            // 
            this.Student_sub_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Student_sub_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Student_sub_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_sub_btn.ForeColor = System.Drawing.Color.Black;
            this.Student_sub_btn.Location = new System.Drawing.Point(361, 246);
            this.Student_sub_btn.Name = "Student_sub_btn";
            this.Student_sub_btn.Size = new System.Drawing.Size(205, 184);
            this.Student_sub_btn.TabIndex = 2;
            this.Student_sub_btn.Text = "Student Attendance Manager";
            this.Student_sub_btn.UseVisualStyleBackColor = false;
            this.Student_sub_btn.Click += new System.EventHandler(this.Student_sub_btn_Click);
            // 
            // ProgramMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(588, 442);
            this.Controls.Add(this.Student_sub_btn);
            this.Controls.Add(this.Lecturer_sub_btn);
            this.Controls.Add(this.Admin_sub_btn);
            this.Name = "ProgramMenu";
            this.Text = "User_Start_Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_sub_btn;
        private System.Windows.Forms.Button Lecturer_sub_btn;
        private System.Windows.Forms.Button Student_sub_btn;
    }
}

