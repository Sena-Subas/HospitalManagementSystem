using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HospitalManagementSystem
{

    
    public partial class SecretaryLogin : Form
    {
        public SecretaryLogin()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection();
        private void SecretaryLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Secretaries where SecretaryNational=@p1 and SecretaryPassword=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
           SqlDataReader dr = command.ExecuteReader();
            if (dr.Read()) 
            {
                SecretaryDetails fr = new SecretaryDetails();
               fr.secnation = maskedTextBox1.Text;

                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid National or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.connection().Close();
            
        }
    }
}
