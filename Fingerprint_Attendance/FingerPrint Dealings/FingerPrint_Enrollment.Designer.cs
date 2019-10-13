namespace Fingerprint_Attendance
{
    partial class FingerPrint_Enrollment
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sex_cmbx = new System.Windows.Forms.ComboBox();
            this.Department_cmbx = new System.Windows.Forms.ComboBox();
            this.Faculty_cmbx = new System.Windows.Forms.ComboBox();
            this.Level_cmbx = new System.Windows.Forms.ComboBox();
            this.Matric_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Enroll_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sample_lbl = new System.Windows.Forms.Label();
            this.FingerPrint_picbx = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerPrint_picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1124, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 647);
            this.vScrollBar1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 623);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sex_cmbx);
            this.groupBox2.Controls.Add(this.Department_cmbx);
            this.groupBox2.Controls.Add(this.Faculty_cmbx);
            this.groupBox2.Controls.Add(this.Level_cmbx);
            this.groupBox2.Controls.Add(this.Matric_txt);
            this.groupBox2.Controls.Add(this.Name_txt);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.Enroll_btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 591);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Sex_cmbx
            // 
            this.Sex_cmbx.FormattingEnabled = true;
            this.Sex_cmbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex_cmbx.Location = new System.Drawing.Point(322, 332);
            this.Sex_cmbx.Name = "Sex_cmbx";
            this.Sex_cmbx.Size = new System.Drawing.Size(121, 21);
            this.Sex_cmbx.TabIndex = 8;
            // 
            // Department_cmbx
            // 
            this.Department_cmbx.FormattingEnabled = true;
            this.Department_cmbx.Location = new System.Drawing.Point(29, 418);
            this.Department_cmbx.Name = "Department_cmbx";
            this.Department_cmbx.Size = new System.Drawing.Size(121, 21);
            this.Department_cmbx.TabIndex = 7;
            // 
            // Faculty_cmbx
            // 
            this.Faculty_cmbx.FormattingEnabled = true;
            this.Faculty_cmbx.Location = new System.Drawing.Point(29, 332);
            this.Faculty_cmbx.Name = "Faculty_cmbx";
            this.Faculty_cmbx.Size = new System.Drawing.Size(121, 21);
            this.Faculty_cmbx.TabIndex = 7;
            // 
            // Level_cmbx
            // 
            this.Level_cmbx.FormattingEnabled = true;
            this.Level_cmbx.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.Level_cmbx.Location = new System.Drawing.Point(322, 418);
            this.Level_cmbx.Name = "Level_cmbx";
            this.Level_cmbx.Size = new System.Drawing.Size(121, 21);
            this.Level_cmbx.TabIndex = 7;
            this.Level_cmbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Matric_txt
            // 
            this.Matric_txt.Location = new System.Drawing.Point(322, 206);
            this.Matric_txt.Multiline = true;
            this.Matric_txt.Name = "Matric_txt";
            this.Matric_txt.Size = new System.Drawing.Size(169, 33);
            this.Matric_txt.TabIndex = 4;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(35, 206);
            this.Name_txt.Multiline = true;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(174, 33);
            this.Name_txt.TabIndex = 4;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(29, 52);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(480, 84);
            this.textBox10.TabIndex = 4;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(322, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Enroll_btn
            // 
            this.Enroll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enroll_btn.Location = new System.Drawing.Point(113, 520);
            this.Enroll_btn.Name = "Enroll_btn";
            this.Enroll_btn.Size = new System.Drawing.Size(96, 38);
            this.Enroll_btn.TabIndex = 5;
            this.Enroll_btn.Text = "Save";
            this.Enroll_btn.UseVisualStyleBackColor = true;
            this.Enroll_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SEX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faculty";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MatricNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "FullName";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(578, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 623);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.sample_lbl);
            this.panel4.Controls.Add(this.FingerPrint_picbx);
            this.panel4.Location = new System.Drawing.Point(18, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 401);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::Fingerprint_Attendance.Properties.Resources._256px_Default_profile_picture__male__on_Facebook;
            this.pictureBox1.Location = new System.Drawing.Point(15, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 265);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start FingerPrint Scanner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sample_lbl
            // 
            this.sample_lbl.AutoSize = true;
            this.sample_lbl.ForeColor = System.Drawing.Color.Red;
            this.sample_lbl.Location = new System.Drawing.Point(27, 306);
            this.sample_lbl.Name = "sample_lbl";
            this.sample_lbl.Size = new System.Drawing.Size(91, 13);
            this.sample_lbl.TabIndex = 1;
            this.sample_lbl.Text = "Samples Needed:";
            // 
            // FingerPrint_picbx
            // 
            this.FingerPrint_picbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FingerPrint_picbx.Location = new System.Drawing.Point(305, 52);
            this.FingerPrint_picbx.Name = "FingerPrint_picbx";
            this.FingerPrint_picbx.Size = new System.Drawing.Size(172, 267);
            this.FingerPrint_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FingerPrint_picbx.TabIndex = 0;
            this.FingerPrint_picbx.TabStop = false;
            this.FingerPrint_picbx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FingerPrint_Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "FingerPrint_Enrollment";
            this.Text = "FingerPrint_Enrollment";
          ///  this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_close);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerPrint_picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Matric_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Enroll_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Department_cmbx;
        private System.Windows.Forms.ComboBox Faculty_cmbx;
        private System.Windows.Forms.ComboBox Level_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox FingerPrint_picbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sample_lbl;
        private System.Windows.Forms.ComboBox Sex_cmbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}