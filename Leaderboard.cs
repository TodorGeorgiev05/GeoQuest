using LogRegPage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogRegPage
{
    public partial class Leaderboard : Form
    {
        private readonly GeoQuestContext _geoQuestContext;
        public Leaderboard()
        {

            InitializeComponent();
            _geoQuestContext = new GeoQuestContext();
            // to initialize from stating point 10 of the peoples with best scores, without matter of the grade
            List<LeaderboardDTO> leaderboardDTOs =
                _geoQuestContext.Users
                .Select(leaderboard => new LeaderboardDTO
                {
                    UserName = leaderboard.UserName,
                    Grade = leaderboard.Grade,
                    ScoreGameOne = leaderboard.HighScore.ScoreGameOne,
                    ScoreGameTwo = leaderboard.HighScore.ScoreGameTwo,
                    Test = 1
                })
                .Take(10)
                .ToList();

            NGSdataGV.AutoGenerateColumns = false;
            leaderboardDTOs[0].ScoreGameTwo = 500;
            NGSdataGV.DataSource = leaderboardDTOs;
        }

        private void dataGridView1_CellContentClick(object er, DataGridViewCellEventArgs e)
        {

        }


        private void ButtonForGeneratingLeaderboard_Click(object sender, EventArgs e)
        {
            //first datatable
            /*            var users = _geoQuestContext.Users.OrderByDescending(t => t.Id).Take(3);
                        LeadreboardGV.DataSource = users.ToList();
                        LeadreboardGV.Columns[0].HeaderText = "ID";*/

            //second datatable
            // to show 10 peoples with matter of grade, and overwrite auto generated information
            var selectedGrade = GradeSelector.SelectedItem.ToString();

            NGSdataGV.DataSource = _geoQuestContext.Users.OrderByDescending(t => t.HighScore)
                .Where(u=>u.Grade == selectedGrade)
                .Take(10)
                .ToList();
            NGSdataGV.AutoGenerateColumns = false;       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NGSdataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainMenu = new MainPage();
            mainMenu.Show();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

        }
    }
}
