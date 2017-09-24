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
        //Connection string to connect to my local SQL DB
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MusicCollection;Integrated Security=True";
        //Creating string to return results for Output Textbox
        string results = "";

        //Serving as the public function to hide connection function from the user
        public string prepareConnection(string queryString)
        {
            //Calling fucntion to recieve SQL Results
            results = executeQuery(queryString);
            //Returning results to Form for Output Textbox
            return results;

        }

        //This function opens the connection and executes the SQL Query.
        private string executeQuery(string queryString)
        {
            //Opening a new SQL connection using the connection string provided by VS. 
            //Since I'm using a using state the connection should close when done.
            using (SqlConnection newConnection = new SqlConnection(connectionString))
            {
                //Creating a new SqlCommand using the queryString created with user input and the SqlConnetion created above.
                SqlCommand command = new SqlCommand(queryString, newConnection);
                //Opening the Sql Connection
                command.Connection.Open();
                //Executing the query
                command.ExecuteNonQuery();
                //Creating a SQLDataReader to read through the results
                SqlDataReader reader = command.ExecuteReader();

                //Looping through the results and composing a string to return to the form for the Output Textbox.
                while (reader.Read())
                {
                    //Adding New Lines to make output more readable (Normal \n wont work for textboxes!)
                    //Reading through results and parsing and labeling the specific columns of results. 
                    results = results + "Artist: " + reader.GetString(1) + Environment.NewLine + "Album: " + reader.GetString(2) + Environment.NewLine + "Year: "
                        + reader.GetInt32(3) + Environment.NewLine + "Notes: " + reader.GetString(4);

                }

                //If not results are returned I'm adding a no result string.
                if (results == "")
                {
                    results = "No result found!";
                }

                //Closing the SQL Reader
                reader.Close();
                //Return the result string.
                return results;
            }



        }




    }
}
