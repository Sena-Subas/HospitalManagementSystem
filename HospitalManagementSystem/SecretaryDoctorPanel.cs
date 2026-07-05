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
    public partial class SecretaryDoctorPanel : Form
    {
        public SecretaryDoctorPanel()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection();

        private void SecretaryDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Doctors", connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand command1 = new SqlCommand("select DepartmentName from Departments", connect.connection());
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0].ToString());
            }
            connect.connection().Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // add doctor button
        {
            SqlCommand command = new SqlCommand("insert into Doctors(DoctorName,DoctorSurname,DoctorDepartment,DoctorNational,DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)", connect.connection());
            command.Parameters.AddWithValue("@d1", textBox1.Text);
            command.Parameters.AddWithValue("@d2", textBox2.Text);
            command.Parameters.AddWithValue("@d3", comboBox1.Text);
            command.Parameters.AddWithValue("@d4", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@d5", textBox3.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Doctor added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // for click in datagridview cell and show the data in textboxes
        {
            int selects = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[selects].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selects].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selects].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[selects].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selects].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)  // Delete doctors button
        {
            SqlCommand command2 = new SqlCommand("delete from Doctors where DoctorNational=@d1", connect.connection());
            command2.Parameters.AddWithValue("@d1", maskedTextBox1.Text);
            command2.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Doctor deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e) // update doctor button
        {
            SqlCommand command3 = new SqlCommand("update Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorDepartment=@p3,DoctorPassword=@p5 where DoctorNational=@p4", connect.connection());
            command3.Parameters.AddWithValue("@p1", textBox1.Text);
            command3.Parameters.AddWithValue("@p2",textBox2.Text);
            command3.Parameters.AddWithValue("@p3", comboBox1.Text);
            command3.Parameters.AddWithValue("@p4",maskedTextBox1.Text);
            command3.Parameters.AddWithValue("@p5", textBox3.Text);
            command3.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Doctor updated successfully","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
