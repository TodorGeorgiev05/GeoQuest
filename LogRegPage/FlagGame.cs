﻿using System.Media;
using LogRegPage.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogRegPage.Models;
using LogRegPage.Repositories;
using LogRegPage.Servisies;

namespace LogRegPage
{
    public partial class FlagGame : Form
    {
        static GeoQuestContext db = new GeoQuestContext();
        private static UserService _userService = new UserService(new UserRepository(db));
        public FlagGame()
        {
            InitializeComponent();
        }
        string randomCountry = "";
        string randomCode = "";

        private void SetRandomCountry(Dictionary<string, string> countries)
        {
            int randomIndex = new Random().Next(countries.Count);
            randomCountry = countries.ElementAt(randomIndex).Key;
            randomCode = countries.ElementAt(randomIndex).Value;
            label1.Text = $"Click on: {randomCountry} ({randomCode})";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int score = 0;
            int guessCount = 0;
            var countries = db.Countries.ToDictionary(c => c.Name, c => c.CountryCode);
            
            // Shuffle the dictionary
            countries = countries.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);

            SetRandomCountry(countries);

            // For pictureBox1 to pictureBox50 set the image to the flag of the country
            for (int i = 1; i <= 50; i++)
            {
                PictureBox pb = (PictureBox)this.Controls.Find($"pictureBox{i}", true)[0];
                pb.Image = Image.FromFile($"Assets/Flags/{countries.ElementAt(i - 1).Value}.png");
                // Also set the name of the picturebox to the country code
                pb.Name = countries.ElementAt(i - 1).Value;
            }


            // When the user clicks a picturebox, check if the name of the picturebox is the same as the randomCode
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    c.Click += (s, ee) =>
                    {
                        if (c.Name == randomCode)
                        {
                            if (guessCount == 0)
                            {
                                score += 5;
                            }
                            if (guessCount == 1)
                            {
                                score += 0;
                            }
                            guessCount = 0;
                            SoundPlayer simpleSound = new SoundPlayer(@"Assets/Sounds/pin.wav");
                            simpleSound.Play();
                            countries.Remove(randomCountry);
                            c.Visible = false;

                            // Remove all previously drawn borders
                            Graphics g = this.CreateGraphics();
                            g.Clear(this.BackColor);

                            if (countries.Count == 0)
                            {
                                MessageBox.Show($"You won! Score: {score}");

                                Session.ScoreService.UpdateFlagGame(score, Session.CurrentUser.Id);
                                return;
                            }
                            SetRandomCountry(countries);
                        }
                        else
                        {
                            guessCount++;
                            // Make the correct picturebox have a green border of 25px using the DrawRectangle method
                            Graphics g = this.CreateGraphics();
                            PictureBox correctPb = (PictureBox)this.Controls.Find(randomCode, true)[0];
                            g.DrawRectangle(new Pen(Color.Green, 10), correctPb.Location.X, correctPb.Location.Y, correctPb.Width, correctPb.Height);
                            if (guessCount == 1)
                            {
                                score += 1;
                            }
                            if (guessCount >= 2)
                            {
                                score += 0;
                            }
                        }
                        scoreLabel.Text = $"Score: {score}";
                    };
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlagGame flagGame = new FlagGame();
            flagGame.Show();
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainMenu = new MainPage();
            mainMenu.Show();
        }
    }
}
