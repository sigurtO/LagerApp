using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LagerApp_final_
{
    
    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        //read
        public (string MedarbejderID, string Password) ReadWorker()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT MedarbejderID, Password FROM Medarbejder;", connection);


            using var reader = command.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read())
                {
                    return (reader["MedarbejderID"].ToString(), reader["Password"].ToString());

                }
            }
            return (null, null);
        }


    }
}
