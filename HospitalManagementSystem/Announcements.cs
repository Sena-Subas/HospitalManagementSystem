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
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection();
        private void Announcements_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Announcements", connect.connection());    
            da.Fill(dt);
            dataGridView1.DataSource = dt;          

        }
    }
}
