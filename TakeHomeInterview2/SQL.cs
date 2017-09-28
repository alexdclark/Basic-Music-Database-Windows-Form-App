using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TakeHomeInterview2
{
    //Setting the SQL Class as Serializable allows to store as XML
    [Serializable()]

   public class SQL : ISerializable
    {

        public SQL()
        { }

        //Creating variables to hold attributes vs hardcoding values for output string
        public String artistName;
        public String albumName;
        public int albumYear;
        public String albumNotes;


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

                //Calling prepareOutput function in order to prepare output string to return to user.
                results = prepareOutput(command);
            }
            
            string prepareOutput (SqlCommand sqlCommand)
            {
                //Creating a SQLDataReader to read through the results
                SqlDataReader reader = sqlCommand.ExecuteReader();

                //Looping through the results and composing a string to return to the form for the Output Textbox.
                while (reader.Read())
                {
                    artistName = reader.GetString(1);
                    albumName = reader.GetString(2);
                    albumYear = reader.GetInt32(3);
                    albumNotes = reader.GetString(4);

                    //Adding New Lines to make output more readable (Normal \n wont work for textboxes!)
                    //Reading through results and parsing and labeling the specific columns of results. 
                    results = results + "Artist: " + artistName + Environment.NewLine + "Album: " + albumName + Environment.NewLine + "Year: "
                        + albumYear + Environment.NewLine + "Notes: " + albumNotes + Environment.NewLine;

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

            return results;
        }

        //Setting the keys for whenever the class is serialized
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Arist Name", artistName);
            info.AddValue("Album Name", albumName);
            info.AddValue("Album Year", albumYear);
            info.AddValue("Album Notes", albumNotes);
        }

        //Setting up the function to unserialize the class
        public SQL(SerializationInfo info, StreamingContext context)
        {
            artistName = (string)info.GetValue("Artist Name", typeof(string));
            albumName = (string)info.GetValue("Album Name", typeof(string));
            albumYear = (Int32)info.GetValue("Album Year", typeof(Int32));
            albumNotes = (string)info.GetValue("Album Notes", typeof(string));
        }



    }

    


}

