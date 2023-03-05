using LogRegPage.Models;
using LogRegPage.Repositories;
using LogRegPage.Servisies;
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
    public partial class Register : Form
    {
        static GeoQuestContext db = new GeoQuestContext();
        private static UserService _userService = new UserService(new UserRepository(db));
        public Register()
        {
            InitializeComponent();
        }

        private void cnfPassword_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsEmpty()
        {
            return (Password.Text.Trim() == "" || Username.Text.Trim() == "");
          
        }
        public void Clear()
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User users = new User();

            if (Password.Text == cnfPassword.Text && !IsEmpty())
            {
                users.UserName = Username.Text;
                users.Password = Password.Text;
                users.UserType = AccountType.SelectedItem.ToString();
                users.Grade = gradeSelector.SelectedItem.ToString();

                db.Users.Add(users);
                db.SaveChanges();
                MessageBox.Show("Success!");

            }
            else
            {
                MessageBox.Show("Invalid password or empty field!");
            }
        }

        private void createAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gradeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
