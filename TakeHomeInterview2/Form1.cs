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
        string queryString;
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
            queryString = "Select * From MusicData WHERE Arist LIKE '" + "%" +findAlbumArtistSearch.Text + "%" +"'";

            outputBox.Clear();
            outputBox.Text = SQLConnect.establishConnection(queryString);
            
            
        }

        private void findAlbum_Click(object sender, EventArgs e)
        {
            queryString = "Select * From MusicData WHERE AlbumName LIKE '" + "%" + findAlbumArtistSearch.Text + "%" + "'";
            outputBox.Clear();
            outputBox.Text = SQLConnect.establishConnection(queryString);
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            queryString = "Insert INTO MusicData Values ('" + artistNameInput.Text + "','" + albumNameInput.Text + "'," + albumYearInput.Text + ",'" + noteBox.Text + "');";
            outputBox.Clear();
            outputBox.Text = SQLConnect.establishConnection(queryString);
        }
    }
}
