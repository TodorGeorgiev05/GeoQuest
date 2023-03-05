using LogRegPage.Models;
using LogRegPage.Repositories;
using LogRegPage.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegPage.Servisies
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetUser(Func<User, bool> filter)
        {
            return _userRepository.GetUser(filter);
        }
        public bool Update(string username, string password, string grade)
        {
            Session.CurrentUser.UserName = username;
            Session.CurrentUser.Password = password;
            Session.CurrentUser.Grade = grade;
            return _userRepository.Update(Session.CurrentUser);
        }
    }
}
