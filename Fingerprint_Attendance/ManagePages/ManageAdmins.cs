using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingerprint_Attendance
{
    public partial class ManageAdmins : Form
    {
        public ManageAdmins()
        {
            InitializeComponent();
        }

        private void ManageAdmins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DataBaseDataSet3.Admin_DB' table. You can move, or remove it, as needed.
            this.admin_DBTableAdapter.Fill(this.login_DataBaseDataSet3.Admin_DB);

        }

        private void ManageAdmins_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin_DBTableAdapter.Update(login_DataBaseDataSet3);
            SqlConnection Connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ifeoluwa\Documents\IFE\Fingerprint_Attendance\Fingerprint_Attendance\Login_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
          ///  string MyQuery = ;
           /// SqlDataAdapter MyAdapter = new SqlDataAdapter(MyQuery, Connection);


            AdminMenu form = new AdminMenu();
            this.Hide();
            form.Show();
        }
    }
}
