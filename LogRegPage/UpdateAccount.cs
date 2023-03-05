using LogRegPage.Models;
using LogRegPage.Repositories;
using LogRegPage.Servisies;
using LogRegPage.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogRegPage
{
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
            // goal is to get id from login and use that login id to can update only the user with that id
/*                       var firstTen = .Users.OrderByDescending(t => t.Id).Take(10);
            UpdateAccDGV.AutoGenerateColumns = false;
            UpdateAccDGV.DataSource = firstTen.ToList();*/
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Session.UserService.Update(Username.Text, Password.Text, GradeSelect.SelectedItem.ToString());
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            
        }
    }
}
