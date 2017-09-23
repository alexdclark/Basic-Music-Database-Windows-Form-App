using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeInterview2
{
    class SQL
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MusicCollection;Integrated Security=True";
        
        string results = "";

        public string establishConnection(string queryString)
        {
            results = connectToDB(queryString);

            return results;

        }

        private string connectToDB(string queryString)
        {
            using (SqlConnection newConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, newConnection);
                command.Connection.Open();
              command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
           
                    results = results + "Artist: " + reader.GetString(1) + Environment.NewLine + "Album: " + reader.GetString(2) + Environment.NewLine + "Year: "
                        + reader.GetInt32(3) + Environment.NewLine + "Notes: " + reader.GetString(4);

                } 
              
                if (results == "")
                {
                    results = "No result found!";
                }

                return results;
            }

         

        }
        



    }
}
