using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using DPFP.Verification;
using System.Data.SqlClient;
using Enrollment;

namespace Fingerprint_Attendance
{
    
    public partial class FingerPrint_Verify : Form ///, DPFP.Capture.EventHandler
    {
        public FingerPrint_Verify()
        {
            InitializeComponent();
        }
    

     

  

 
          
           



            ///  SqlDataReader reader = MyQuery.ExecuteReader();
           
            /// DPFP.FeatureSet features = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification);



        
        private void button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ifeoluwa\Desktop\Fingerprint_Attendance\Fingerprint_Attendance\Login_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
             Connection.Open();
             SqlCommand MyQuery = new SqlCommand("Select * FROM  FingerPrint_tbl Where FingerPrint ='" + fingerPrintInfo + "'", Connection);



             Verification.Result verifyResult = new Verification.Result();
             Verification verificator = new Verification();
             FeatureSet featureSet = new FeatureSet();

             Template template = new Template();
             FeatureExtraction featureExtractor = new FeatureExtraction();
             CaptureFeedback feedback = new CaptureFeedback();
             featureExtractor.CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Verification, ref feedback, ref featureSet);
             template.DeSerialize(fingerPrintInfo);
             verificator.Verify(featureSet, template, ref verifyResult);


             if (verifyResult.Verified)
             {

                 MessageBox.Show("Verified");

             }
             else
             {
                 MessageBox.Show("not verified, try again");
             }*/

            MainForm mainform = new MainForm();
            
            mainform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FingerPrint_Enrollment enrol = new FingerPrint_Enrollment();
            enrol.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgramMenu form = new ProgramMenu();
            this.Hide();

        }

  

       

        private void FingerPrint_Verify_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramMenu form = new ProgramMenu();
            this.Hide();
           
        }
    }

}
