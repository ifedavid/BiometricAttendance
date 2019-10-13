using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Fingerprint_Attendance
{
    public partial class ProgramStartPage : Form
    {
        public ProgramStartPage()
        {
            InitializeComponent();
        }

        private void Welcome_lbl_Click(object sender, EventArgs e)
        {

        }

        private void viewAdministartorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FingerPrint_Enrollment FinPrin =new FingerPrint_Enrollment();
            
            FinPrin.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAdministratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            panel2.Visible = false;
           
           

          

        }

        private void assignRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           


            

        }

        private void addLecturerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Add_Lecturer_btn_Click(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Add_DeptCrs_btn_Click(object sender, EventArgs e)
        {

                    
        }

        private void Create_NewAdmin_btn_Click(object sender, EventArgs e)
        {

       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editCurrentAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void assignRoleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lecturer_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturer_TableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.login_DataBaseDataSet);

        }

        private void Admin_SubMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DataBaseDataSet.Lecturer_Table' table. You can move, or remove it, as needed.
            ///this.lecturer_TableTableAdapter.Fill(this.login_DataBaseDataSet.Lecturer_Table);

        }

        private void manageLecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ///dataGridView1.Visible = true;
            


            panel2.Visible = false;


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LecturerPass_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewAttendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProgramMenu form = new ProgramMenu();
            form.Show();
           
            
        }

        private void ProgramStartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
