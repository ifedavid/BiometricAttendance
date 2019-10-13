namespace Fingerprint_Attendance
{
    partial class ProgramStartPage
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
            this.components = new System.ComponentModel.Container();
            this.lecturerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_DataBaseDataSet = new Fingerprint_Attendance.Login_DataBaseDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturer_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturer_TableTableAdapter = new Fingerprint_Attendance.Login_DataBaseDataSetTableAdapters.Lecturer_TableTableAdapter();
            this.tableAdapterManager = new Fingerprint_Attendance.Login_DataBaseDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DataBaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturer_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lecturerTableBindingSource
            // 
            this.lecturerTableBindingSource.DataMember = "Lecturer_Table";
            this.lecturerTableBindingSource.DataSource = this.login_DataBaseDataSet;
            // 
            // login_DataBaseDataSet
            // 
            this.login_DataBaseDataSet.DataSetName = "Login_DataBaseDataSet";
            this.login_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lecturer_TableBindingSource
            // 
            this.lecturer_TableBindingSource.DataMember = "Lecturer_Table";
            this.lecturer_TableBindingSource.DataSource = this.login_DataBaseDataSet;
            // 
            // lecturer_TableTableAdapter
            // 
            this.lecturer_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Admin_DBTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.Lecturer_TableTableAdapter = this.lecturer_TableTableAdapter;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Fingerprint_Attendance.Login_DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 332);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(42, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(662, 90);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome To Your FingerPrint Attendance  \r\n                               System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SlateGray;
            this.label10.Location = new System.Drawing.Point(177, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 64);
            this.label10.TabIndex = 1;
            this.label10.Text = "     To Access Any Function, \r\nPlease Click on the menus above ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(299, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Started";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 332);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProgramStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProgramStartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_SubMenu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramStartPage_FormClosed);
            this.Load += new System.EventHandler(this.Admin_SubMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_DataBaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturer_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Login_DataBaseDataSet login_DataBaseDataSet;
        private System.Windows.Forms.BindingSource lecturer_TableBindingSource;
        private Login_DataBaseDataSetTableAdapters.Lecturer_TableTableAdapter lecturer_TableTableAdapter;
        private Login_DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lecturerTableBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}