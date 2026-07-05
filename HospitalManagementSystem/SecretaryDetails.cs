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
using System.Data.SqlClient;
using System.Data.Common;


namespace HospitalManagementSystem
{
    public partial class SecretaryDetails : Form
    {
   public SecretaryDetails()
        {
            InitializeComponent();
        }


        MySqlConnection connect = new MySqlConnection();

        public string secnation;

        private void SecretaryDetails_Load(object sender, EventArgs e)

        {

            label4.Text = secnation;

            SqlCommand command = new SqlCommand("select SecretaryFullName from Secretaries where SecretaryNational=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", secnation);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0].ToString();
            }
            connect.connection().Close();


            //for appointment datagridview
            DataTable at = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter("select * from Appointments", connect.connection());
            ada.Fill(at);
            dataGridView4.DataSource = at;



            // for departments of datagridview

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Departments", connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            DataTable dts = new DataTable();
            SqlDataAdapter dsa = new SqlDataAdapter("select DoctorName,DoctorSurname,DoctorDepartment from Doctors", connect.connection());
            dsa.Fill(dts);
            dataGridView3.DataSource = dts;



            SqlCommand command2 = new SqlCommand("select DepartmentName from Departments", connect.connection());
            SqlDataReader dr1 = command2.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0]);
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Appointments (AppointmentDate,AppointmentTime,AppointmentDepartment,AppointmentDoctor) values (@r1,@r2,@r3,@r4)", connect.connection());
            command1.Parameters.AddWithValue("@r1", maskedTextBox1.Text);
            command1.Parameters.AddWithValue("@r2", maskedTextBox2.Text);
            command1.Parameters.AddWithValue("@r3", comboBox1.Text);
            command1.Parameters.AddWithValue("@r4", comboBox2.Text);
            command1.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Appointment created successfully");
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
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command4 = new SqlCommand("insert into Announcements (Announcement) values (@a1)", connect.connection());
            command4.Parameters.AddWithValue("@a1", richTextBox1.Text);
            command4.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Announcement created successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SecretaryDoctorPanel scdp = new SecretaryDoctorPanel();
            scdp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SecretaryDepartmentPanel scdp = new SecretaryDepartmentPanel();
            scdp.Show();
        }
        public int choose;
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choose = dataGridView4.SelectedCells[0].RowIndex;
            maskedTextBox1.Text = dataGridView4.Rows[choose].Cells[1].Value.ToString();
            maskedTextBox2.Text = dataGridView4.Rows[choose].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView4.Rows[choose].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView4.Rows[choose].Cells[4].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command4 = new SqlCommand("update Appointments set AppointmentDate=@a1,AppointmentTime=@a2,AppointmentDepartment=@a3,AppointmentDoctor=@a4 where AppointmentID=@a5", connect.connection());
            command4.Parameters.AddWithValue("@a1", maskedTextBox1.Text);
            command4.Parameters.AddWithValue("@a2", maskedTextBox2.Text);
            command4.Parameters.AddWithValue("@a3", comboBox1.Text);
            command4.Parameters.AddWithValue("@a4", comboBox2.Text);
            command4.Parameters.AddWithValue("@a5", dataGridView4.Rows[choose].Cells[0].Value.ToString());
            command4.ExecuteNonQuery();
            MessageBox.Show("Appointment updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connect.connection().Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Announcements anf= new Announcements();
            anf.Show();
        }
    }
}
