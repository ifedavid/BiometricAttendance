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
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DataBaseDataSet1.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.login_DataBaseDataSet1.StudentTable);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            studentTableTableAdapter.Update(login_DataBaseDataSet1);
            AdminMenu form = new AdminMenu();
            this.Hide();
            form.Show();
        }
    }
}
