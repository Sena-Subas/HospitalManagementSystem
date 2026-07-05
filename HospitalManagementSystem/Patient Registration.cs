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

namespace HospitalManagementSystem
{
    public partial class Patient_Registration : Form
    {
        public Patient_Registration()
        {
            InitializeComponent();
        }


        MySqlConnection cnt = new MySqlConnection();


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Patients(PatientName,PatientSurname,PatientNational,PatientPhoneNumber,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)",cnt.connection());
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p4",maskedTextBox2.Text);
            command.Parameters.AddWithValue("@p5", textBox3.Text);
            command.Parameters.AddWithValue("@p6", comboBox1.Text);
            command.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Patient registration is successful.Password: " + textBox3.Text,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        
    }
}
