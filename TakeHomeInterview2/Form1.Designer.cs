namespace TakeHomeInterview2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.findAlbumArtistSearch = new System.Windows.Forms.TextBox();
            this.findArtistButton = new System.Windows.Forms.Button();
            this.findAlbum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.artistNameInput = new System.Windows.Forms.TextBox();
            this.albumNameInput = new System.Windows.Forms.TextBox();
            this.albumYearLabel = new System.Windows.Forms.Label();
            this.albumYearInput = new System.Windows.Forms.TextBox();
            this.albumYearL = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findAlbumArtistSearch
            // 
            this.findAlbumArtistSearch.Location = new System.Drawing.Point(12, 12);
            this.findAlbumArtistSearch.Name = "findAlbumArtistSearch";
            this.findAlbumArtistSearch.Size = new System.Drawing.Size(432, 26);
            this.findAlbumArtistSearch.TabIndex = 0;
            this.findAlbumArtistSearch.Text = "Find Artist or Album";
            this.findAlbumArtistSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findArtistButton
            // 
            this.findArtistButton.Location = new System.Drawing.Point(12, 54);
            this.findArtistButton.Name = "findArtistButton";
            this.findArtistButton.Size = new System.Drawing.Size(160, 65);
            this.findArtistButton.TabIndex = 1;
            this.findArtistButton.Text = "Find Arist";
            this.findArtistButton.UseVisualStyleBackColor = true;
            this.findArtistButton.Click += new System.EventHandler(this.findArtistButton_Click);
            // 
            // findAlbum
            // 
            this.findAlbum.Location = new System.Drawing.Point(284, 54);
            this.findAlbum.Name = "findAlbum";
            this.findAlbum.Size = new System.Drawing.Size(160, 65);
            this.findAlbum.TabIndex = 2;
            this.findAlbum.Text = "Find Album";
            this.findAlbum.UseVisualStyleBackColor = true;
            this.findAlbum.Click += new System.EventHandler(this.findAlbum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add a new Album or Artist";
            // 
            // artistNameLabel
            // 
            this.artistNameLabel.AutoSize = true;
            this.artistNameLabel.Location = new System.Drawing.Point(53, 216);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(92, 20);
            this.artistNameLabel.TabIndex = 4;
            this.artistNameLabel.Text = "Artist Name";
            // 
            // artistNameInput
            // 
            this.artistNameInput.Location = new System.Drawing.Point(180, 197);
            this.artistNameInput.Multiline = true;
            this.artistNameInput.Name = "artistNameInput";
            this.artistNameInput.Size = new System.Drawing.Size(230, 50);
            this.artistNameInput.TabIndex = 5;
            // 
            // albumNameInput
            // 
            this.albumNameInput.Location = new System.Drawing.Point(180, 267);
            this.albumNameInput.Multiline = true;
            this.albumNameInput.Name = "albumNameInput";
            this.albumNameInput.Size = new System.Drawing.Size(230, 50);
            this.albumNameInput.TabIndex = 7;
            // 
            // albumYearLabel
            // 
            this.albumYearLabel.AutoSize = true;
            this.albumYearLabel.Location = new System.Drawing.Point(53, 286);
            this.albumYearLabel.Name = "albumYearLabel";
            this.albumYearLabel.Size = new System.Drawing.Size(100, 20);
            this.albumYearLabel.TabIndex = 6;
            this.albumYearLabel.Text = "Album Name";
            // 
            // albumYearInput
            // 
            this.albumYearInput.Location = new System.Drawing.Point(180, 338);
            this.albumYearInput.Multiline = true;
            this.albumYearInput.Name = "albumYearInput";
            this.albumYearInput.Size = new System.Drawing.Size(230, 50);
            this.albumYearInput.TabIndex = 9;
            // 
            // albumYearL
            // 
            this.albumYearL.AutoSize = true;
            this.albumYearL.Location = new System.Drawing.Point(53, 358);
            this.albumYearL.Name = "albumYearL";
            this.albumYearL.Size = new System.Drawing.Size(92, 20);
            this.albumYearL.TabIndex = 8;
            this.albumYearL.Text = "Album Year";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(180, 407);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(230, 50);
            this.noteBox.TabIndex = 11;
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(53, 426);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(87, 20);
            this.Notes.TabIndex = 10;
            this.Notes.Text = "Arist Notes";
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(12, 536);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(433, 231);
            this.outputBox.TabIndex = 12;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(19, 473);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(432, 47);
            this.completeButton.TabIndex = 13;
            this.completeButton.Text = "Add Artist or Album";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 777);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Convert to XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(456, 827);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.albumYearInput);
            this.Controls.Add(this.albumYearL);
            this.Controls.Add(this.albumNameInput);
            this.Controls.Add(this.albumYearLabel);
            this.Controls.Add(this.artistNameInput);
            this.Controls.Add(this.artistNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findAlbum);
            this.Controls.Add(this.findArtistButton);
            this.Controls.Add(this.findAlbumArtistSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Basic Music Database ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findAlbumArtistSearch;
        private System.Windows.Forms.Button findArtistButton;
        private System.Windows.Forms.Button findAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.TextBox artistNameInput;
        private System.Windows.Forms.TextBox albumNameInput;
        private System.Windows.Forms.Label albumYearLabel;
        private System.Windows.Forms.TextBox albumYearInput;
        private System.Windows.Forms.Label albumYearL;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button button1;
    }
}

