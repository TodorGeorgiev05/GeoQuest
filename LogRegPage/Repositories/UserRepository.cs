using LogRegPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegPage.Repositories
{
    public class UserRepository
    {
        private readonly GeoQuestContext _geoQuestContext;
        public UserRepository(GeoQuestContext geoQuestContext)
        {
            _geoQuestContext = geoQuestContext;
        }
        public User GetUser(Func<User, bool> filter)
        {
            return _geoQuestContext.Users.Where(filter).FirstOrDefault();
        }
        public bool Update(User user)
        {
            _geoQuestContext.Users.Update(user);
            _geoQuestContext.SaveChanges();
            return true;
        }
    }
}
