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
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.Pkcs;
using System.Diagnostics.Eventing.Reader;
namespace HospitalManagementSystem
{
    public partial class PatientLoginFrm : Form
    {
        public PatientLoginFrm()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient_Registration patient_registration = new Patient_Registration();
            patient_registration.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from Patients where PatientNational=@p1 and PatientPassword=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Patient_Details fr = new Patient_Details();
                fr.national = maskedTextBox1.Text;

                fr.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid National ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.connection().Close();

        }

        private void PatientLoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void PatientLoginFrm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
