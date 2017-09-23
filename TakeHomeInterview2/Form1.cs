using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeInterview2
{
    public partial class Form1 : Form 
    {
        //Creating String container for query string to be modified depending on user input
        string queryString;
        //Creating instance of SQL Class to allow for connection to the Local DB
        SQL SQLConnect = new SQL();

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
            queryString = "Select * From MusicData WHERE Arist LIKE '" + "%" +findAlbumArtistSearch.Text + "%" +"'";
            //Clearing the Output textbox to prepare for new output
            outputBox.Clear();
            //Calling the establishConenction function to query the local SQL DB
            outputBox.Text = SQLConnect.establishConnection(queryString);
           
        }

        private void findAlbum_Click(object sender, EventArgs e)
        {
            //Preparing query String for Find Album by constructing Select statement to find artist with user input
            queryString = "Select * From MusicData WHERE AlbumName LIKE '" + "%" + findAlbumArtistSearch.Text + "%" + "'";
            //Clearing the Output textbox to preapre for new output
            outputBox.Clear();
            //Calling the establishConenction function to query the local SQL DB
            outputBox.Text = SQLConnect.establishConnection(queryString);
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            //Preparing query String to insert new arist/album by constructing insert statement with user input
            queryString = "Insert INTO MusicData Values ('" + artistNameInput.Text + "','" + albumNameInput.Text + "'," + albumYearInput.Text + ",'" + noteBox.Text + "');";
            //Clearing the Output Textbox to prepare for new output
            outputBox.Clear();
            //Calling the establishConnection function to insert new Arist/Album
            outputBox.Text = SQLConnect.establishConnection(queryString);
        }
    }
}
