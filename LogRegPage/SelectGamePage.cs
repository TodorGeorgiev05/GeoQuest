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
    public partial class SelectGamePage : Form
    {
        public SelectGamePage()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void UpdateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAccount update = new UpdateAccount();
            update.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAccount update = new UpdateAccount();
            update.Show();
        }
    }
}
