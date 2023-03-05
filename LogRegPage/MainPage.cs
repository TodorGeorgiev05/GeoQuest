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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
        }
    }
}
