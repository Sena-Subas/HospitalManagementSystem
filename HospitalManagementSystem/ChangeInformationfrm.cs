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
using System.Runtime.Serialization;

namespace HospitalManagementSystem
{
    public partial class ChangeInformationfrm : Form
    {
        public ChangeInformationfrm()
        {
            InitializeComponent();
        }

        public string NationalNumber;

        MySqlConnection connect = new MySqlConnection();

        // The codes here is for changing tools to populate with old information.
        private void ChangeInformationfrm_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = NationalNumber;
            SqlCommand command = new SqlCommand("select * from Patients where PatientNational=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                textBox3.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();
            }
            connect.connection().Close();
        }

        // The codes here is for updating the information of the patient.

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Patients set PatientName=@p1,PatientSurname=@p2,PatientPhoneNumber=@p3,PatientPassword=@p4,PatientGender=@p5 where PatientNational=@p6", connect.connection());
            command2.Parameters.AddWithValue("@p1",textBox1.Text);
            command2.Parameters.AddWithValue("@p2", textBox2.Text);
            command2.Parameters.AddWithValue("@p3", maskedTextBox2.Text);   
            command2.Parameters.AddWithValue("@p4", textBox3.Text);
            command2.Parameters.AddWithValue("@p5", comboBox1.Text);
            command2.Parameters.AddWithValue("@p6", maskedTextBox1.Text);
            command2.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Information updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
