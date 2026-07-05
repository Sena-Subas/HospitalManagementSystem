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
    public partial class DoctorLoginFrm : Form
    {
        public DoctorLoginFrm()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection();


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Doctors where DoctorNational=@p1 and DoctorPassword=@p2",connection.connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2",textBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                DoctorDetails fr = new DoctorDetails();
                fr.docnation=maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid National or Password Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.connection().Close();
        }
    }
}
