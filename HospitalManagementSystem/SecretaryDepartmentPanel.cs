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
    public partial class SecretaryDepartmentPanel : Form
    {
        public SecretaryDepartmentPanel()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection();
        private void label2_Click(object sender, EventArgs e)
        { }


        private void SecretaryDepartmentPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Departments", connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Departments(DepartmentName) values (@a1)", connect.connection());
            command.Parameters.AddWithValue("@a1", textBox1.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Department added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[slct].Cells[0].Value);
            SqlCommand command2 = new SqlCommand("delete from Departments where DepartmentID=@b1", connect.connection());
            command2.Parameters.AddWithValue("@b1", id);
            command2.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Department deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int slct;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            slct = dataGridView1.SelectedCells[0].RowIndex;
            
            textBox1.Text = dataGridView1.Rows[slct].Cells[1].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("update Departments set DepartmentName=@n1 where DepartmentID=@n2", connect.connection());
            command3.Parameters.AddWithValue("@n1", textBox1.Text);
            command3.Parameters.AddWithValue("@n2", dataGridView1.Rows[slct].Cells[0].Value);
            command3.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Department updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
