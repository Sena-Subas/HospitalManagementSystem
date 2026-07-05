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

namespace HospitalManagementSystem
{
    public partial class Doctor_Information_Editing : Form
    {
        public Doctor_Information_Editing()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection();

        public string DcNational;

        private void Doctor_Information_Editing_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DcNational;
            SqlCommand command = new SqlCommand("select * from Doctors where DoctorNational=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", DcNational);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                comboBox1.Text = dr[3].ToString();
                textBox3.Text = dr[5].ToString();
            }
            connect.connection().Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Doctors set DoctorName=@d1,DoctorSurname=@d2,DoctorDepartment=@d3,DoctorPassword=@d4 where DoctorNational=@p5", connect.connection());
            command1.Parameters.AddWithValue("@d1",textBox1.Text);
            command1.Parameters.AddWithValue("@d2",textBox2.Text);
            command1.Parameters.AddWithValue("@d3",comboBox1.Text);
            command1.Parameters.AddWithValue("@d4", textBox3.Text);
            command1.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            command1.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Information Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
