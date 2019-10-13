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
    public partial class Lecturer_Login : Form
    {
        public Lecturer_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ifeoluwa\Documents\IFE\Fingerprint_Attendance\Fingerprint_Attendance\Login_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            string MyQuery = "Select * from  Lecturer_Table Where Lec_Username ='" +StaffID_txt.Text.Trim() + "' and Lec_PassWord ='" + LecPass_txt.Text.Trim() + "'";
            SqlDataAdapter MyAdapter = new SqlDataAdapter(MyQuery, Connection);
            DataTable MyDataTable = new DataTable();
            MyAdapter.Fill(MyDataTable);
            if (MyDataTable.Rows.Count == 1)
            {

                panel1.Visible = false;
                panel2.Visible = true;


            }
            else
            {
                MessageBox.Show("Please input the correct Username and Passsword");
            }
            Connection.Close();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Duration_dman_SelectedItemChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FingerPrint_Verify activate = new FingerPrint_Verify();


            string Timer = time_txt.Text;
            if (Timer == null || Timer == "")
            {
                MessageBox.Show("please add a timer");
            }
            else
            {
                int time = Convert.ToInt32(Timer);
                TimeSpan timer = new TimeSpan(0, time, 0);

                TimeSpan one_sec = new TimeSpan(0, 0, 1);
                for (int i = 0; i <= timer.Seconds; i++)
                {
                    timer.Subtract(one_sec);
                }

               
                if (timer.TotalSeconds == 0 || time_txt.Text == "0")
                {
                    MessageBox.Show("please set a timer");
                    ///activate.Close();
                }
                else
                {
                 
                    activate.ShowDialog();
                    
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgramMenu userpage = new ProgramMenu();
            this.Hide();
            userpage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lecturer_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramMenu form = new ProgramMenu();
            this.Hide();
            form.Show();
        }

        private void Lecturer_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
