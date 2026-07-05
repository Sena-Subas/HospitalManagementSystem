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
    public partial class Patient_Details : Form
    {
        public Patient_Details()
        {
            InitializeComponent();
        }
        public string national;  // this variable is for patient details in label1.text 

        MySqlConnection connect = new MySqlConnection();

public int Select1; 
        private void Patient_Details_Load(object sender, EventArgs e)
        {                         // those codes are for label3.text 
            label1.Text = national;

            SqlCommand command = new SqlCommand("select PatientName,PatientSurname from Patients where PatientNational=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", label1.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0] + " " + dr[1];
            }
            connect.connection().Close();

            //those codes for History Appointments

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Appointments where PatientNational= " + national, connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //For Departments Combobox1

            SqlCommand command2 = new SqlCommand("Select DepartmentName from Departments", connect.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            SqlCommand command3 = new SqlCommand("select DoctorName,DoctorSurname from Doctors where DoctorDepartment=@p1", connect.connection());
            command3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0] + " " + dr3[1]);
            }
            connect.connection().Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Appointments where AppointmentDepartment= '" + comboBox1.Text + "' and AppointmentDoctor='" + comboBox2.Text + "' and AppointmentStatus=0", connect.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeInformationfrm fr = new ChangeInformationfrm();
            fr.NationalNumber = label1.Text;
            fr.Show();

        }
       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Select1 = dataGridView2.SelectedCells[0].RowIndex;
            
            comboBox1.Text = dataGridView2.Rows[Select1].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[Select1].Cells[4].Value.ToString();
            richTextBox1.Text = dataGridView2.Rows[Select1].Cells[7].Value.ToString();
        }
         
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Appointments set AppointmentStatus=1, PatientNational=@p1,PatientComplaint=@p2 where AppointmentID=@p3", connect.connection());
            command1.Parameters.AddWithValue("@p1", label1.Text);
            command1.Parameters.AddWithValue("@p2", richTextBox1.Text);
            command1.Parameters.AddWithValue("@p3", dataGridView2.Rows[Select1].Cells[0].Value);
            command1.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Appointment has been successfully booked.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
