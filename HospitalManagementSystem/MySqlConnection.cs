using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;

namespace HospitalManagementSystem

{
    internal class MySqlConnection
    {

        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Server=DESKTOP-TEBLO4M\\SQLEXPRESS;Database=HospitalManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");
            connect.Open();
            return connect;
        }
        
    }
}
