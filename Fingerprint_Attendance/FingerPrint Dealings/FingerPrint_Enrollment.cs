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
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using Enrollment;

namespace Fingerprint_Attendance
{
    public partial class FingerPrint_Enrollment : Form 
    {

        public FingerPrint_Enrollment()
        {
            InitializeComponent();
           /// cp.StartCapture();
           /// cp.EventHandler = this ;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
          
        }


      
        private void button4_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "" || Matric_txt.Text == "" || Level_cmbx.Text == "" || Faculty_cmbx.Text == "" || Department_cmbx.Text == ""
                || Sex_cmbx.Text == "" || FingerPrint_picbx.Image == null)
            {

                MessageBox.Show("Please fill every empty box", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ifeoluwa\Documents\IFE\Fingerprint_Attendance\Fingerprint_Attendance\Login_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
                connect.Open();
                SqlCommand comm = new SqlCommand("AddStudent", connect);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@FullName", Name_txt.Text.Trim());
                comm.Parameters.AddWithValue("@MatricNo", Matric_txt.Text.Trim());
                comm.Parameters.AddWithValue("@Level", Level_cmbx.Text.Trim());
                comm.Parameters.AddWithValue("@Faculty", Faculty_cmbx.Text.Trim());
                comm.Parameters.AddWithValue("@Department", Department_cmbx.Text.Trim());
                comm.Parameters.AddWithValue("@Sex", Sex_cmbx.Text.Trim());

                SqlCommand command = new SqlCommand("AddFingerPrint", connect);
                comm.CommandType = CommandType.StoredProcedure;
              ///  comm.Parameters.AddWithValue("@FingerPrint", fingerPrintInfo);

                comm.ExecuteNonQuery();
                MessageBox.Show("Added new print");

                ///  comm.Parameters.AddWithValue("@FingerPrint", FingerPrint_picbx.Text.Trim());
                comm.ExecuteNonQuery();
                MessageBox.Show("NeW Student Added. Success!");
                Name_txt.Text = "";
                Matric_txt.Text = "";
                Level_cmbx.Text = "";
                Faculty_cmbx.Text = "";
                Department_cmbx.Text = "";
                Sex_cmbx.Text = "";
                FingerPrint_picbx.Image = null;
                string myquery = "SELECT * FROM StudentTable";
                SqlDataAdapter sda = new SqlDataAdapter(myquery, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            
        }
   


    
    
  
 
        public void form_close()
        {

        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            EnrollmentForm form = new EnrollmentForm();
            form.Show();
        }
    }
}
