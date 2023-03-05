using LogRegPage.Models;
using LogRegPage.Repositories;
using LogRegPage.Servisies;
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

namespace LogRegPage
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        public void Clear()
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = Username.Text;
            string pass = Password.Text;
           // var id = Convert.ToInt32(db.Rows[0]["loginID"].ToString().Trim());
            User userFound = Session.UserService.GetUser(s => s.UserName == name && s.Password == pass);

            string message =  userFound != null ? "Login Success!" : "Login Failed";
            MessageBox.Show(message);
            Clear();
            if (userFound != null )
            {
                Session.CurrentUser = userFound;
                this.Hide();
                SelectGamePage selectGamePage = new SelectGamePage();
                selectGamePage.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
