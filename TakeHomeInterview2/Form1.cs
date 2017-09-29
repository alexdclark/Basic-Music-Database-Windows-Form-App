using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TakeHomeInterview2
{
    public partial class Form1 : Form
    {
        //Creating String container for query string to be modified depending on user input
        string queryString;
        string outputText;
        //Creating instance of Music Database Class to allow for connection to the Local DB and Album Class
        Album newAlbum = new Album();
        MusicDatabase musicDatabase = new MusicDatabase();
        
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void findArtistButton_Click(object sender, EventArgs e)
        {
           

        //Preparing query String for Find Artist by constructing Select statement to find artist with user input
        queryString = "Select * From MusicData WHERE Arist LIKE '" + "%" + findAlbumArtistSearch.Text + "%" + "'";
            //Clearing the Output textbox to prepare for new output
            outputBox.Clear();
            //Calling the establishConenction function to query the local SQL DB
            outputText = musicDatabase.prepareConnection(queryString, newAlbum);
            outputBox.Text = outputText;

        }
        private void findAlbum_Click(object sender, EventArgs e)
        {
            //Preparing query String for Find Album by constructing Select statement to find artist with user input
            queryString = "Select * From MusicData WHERE AlbumName LIKE '" + "%" + findAlbumArtistSearch.Text + "%" + "'";
            //Clearing the Output textbox to preapre for new output
            outputBox.Clear();
            //Calling the establishConenction function to query the local SQL DB
            outputText = musicDatabase.prepareConnection(queryString,newAlbum);
            outputBox.Text = outputText;
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            //Preparing query String to insert new arist/album by constructing insert statement with user input
            queryString = "Insert INTO MusicData Values ('" + artistNameInput.Text + "','" + albumNameInput.Text + "'," + albumYearInput.Text + ",'" + noteBox.Text + "');";
            //Clearing the Output Textbox to prepare for new output
            outputBox.Clear();
            //Calling the establishConnection function to insert new Arist/Album
           outputText = musicDatabase.prepareConnection(queryString,newAlbum);
            outputBox.Text = outputText;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Preparing query String to insert new arist/album by constructing insert statement with user input
            queryString = "Create Table MusicDataNew (ID int identity(1,1), Artist Text, AlbumName Text, AlbumYear int, AlbumDescription Text, PRIMARY KEY (ID))";

            //Clearing the Output Textbox to prepare for new output
            outputBox.Clear();
            //Calling the establishConnection function to insert new Arist/Album
            outputText = musicDatabase.prepareConnection(queryString,newAlbum);
            outputBox.Text = outputText;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            


        }
    }
}
