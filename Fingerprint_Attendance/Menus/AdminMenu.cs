using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingerprint_Attendance
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageStudents form = new ManageStudents();
            this.Hide();
            form.Show();
            
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            ManageLecturers form = new ManageLecturers();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageAdmins form = new ManageAdmins();
            this.Hide();
            form.Show();
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramMenu form = new ProgramMenu();
            this.Hide();
            form.Show();
        }
    }
}
