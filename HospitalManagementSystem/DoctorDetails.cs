using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class DoctorDetails : Form
    {
        public DoctorDetails()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection();

        public string docnation;

        
        private void DoctorDetails_Load(object sender, EventArgs e)
        {
            label2.Text = docnation;

            SqlCommand command = new SqlCommand("select DoctorName, DoctorSurname from Doctors where DoctorNational=@p1", connection.connection());
            command.Parameters.AddWithValue("@p1", docnation);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0].ToString();
                label6.Text = dr[1].ToString();
            }
            connection.connection().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Appointments where AppointmentDoctor=@p1", connection.connection());
            da.SelectCommand.Parameters.AddWithValue("@p1", label3.Text + " " + label6.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            
        }
        
        public int choose1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choose1 = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[choose1].Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor_Information_Editing dcie = new Doctor_Information_Editing();
            dcie.DcNational = label2.Text;
            dcie.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Announcements an = new Announcements();
            an.Show();
        }
    }
}
