using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Fingerprint_Attendance
{
    public partial class ProgramMenu : Form
    {
        public ProgramMenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Login Admin_Login = new Admin_Login();
            this.Hide();
            Admin_Login.ShowDialog();
        }

        private void Lecturer_sub_btn_Click(object sender, EventArgs e)
        {
            Lecturer_Login LecturerLogin = new Lecturer_Login();
            this.Hide();
            LecturerLogin.ShowDialog();
        }

        private void Student_sub_btn_Click(object sender, EventArgs e)
        {
            FingerPrint_Verify verify = new FingerPrint_Verify();
           
            verify.ShowDialog();
        }

        private void ProgramMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramStartPage form = new ProgramStartPage();
            this.Hide();
            form.Show();
        }

        /*   private void Admin_Login_btn_Click(object sender, EventArgs e)
           {

             
       }*/
    }
}
