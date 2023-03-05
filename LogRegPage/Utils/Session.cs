using LogRegPage.Models;
using LogRegPage.Repositories;
using LogRegPage.Servisies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegPage.Utils
{
    public static class Session
    {
        // TODO: is good to be singelton
        private static GeoQuestContext DB = new GeoQuestContext();
        public static UserService UserService = new UserService(new UserRepository(DB));
        public static User CurrentUser;
    }
}
