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
    public partial class ManageLecturers : Form
    {
        public ManageLecturers()
        {
            InitializeComponent();
        }

        private void ManageLecturers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DataBaseDataSet2.Lecturer_Table' table. You can move, or remove it, as needed.
            this.lecturer_TableTableAdapter.Fill(this.login_DataBaseDataSet2.Lecturer_Table);

        }

        private void ManageLecturers_FormClosed(object sender, FormClosedEventArgs e)
        {
            lecturer_TableTableAdapter.Update(login_DataBaseDataSet2);
            AdminMenu form = new AdminMenu();
            this.Hide();
            form.Show();
        }
    }
}
