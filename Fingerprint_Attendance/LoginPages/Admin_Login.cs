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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Cancel_btn_Click(object sender, EventArgs e)
        {
            ProgramMenu Start_Page = new ProgramMenu();
            this.Hide();
            Start_Page.ShowDialog();
        }

        private void Admin_Login_btn_Click(object sender, EventArgs e)
        {
              SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ifeoluwa\Documents\IFE\Fingerprint_Attendance\Fingerprint_Attendance\Login_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
               string MyQuery = "Select * from  Admin_DB Where Username ='" + Admin_UsrNm_txt.Text.Trim() + "' and password ='" + Admin_Psswrd_txt.Text.Trim() + "'";
               SqlDataAdapter MyAdapter = new SqlDataAdapter(MyQuery, Connection);
               DataTable MyDataTable = new DataTable();
               MyAdapter.Fill(MyDataTable);
               if(MyDataTable.Rows.Count == 1)
               {
                   AdminMenu AdminMenu = new AdminMenu();
                this.Hide();
                   AdminMenu.ShowDialog();


               }
               else {
                   MessageBox.Show("Please input the correct Username and Passsword");
               }
               Connection.Close();

           }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

