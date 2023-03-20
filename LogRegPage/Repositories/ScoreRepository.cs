using LogRegPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegPage.Repositories
{
    public class ScoreRepository
    {
        private readonly GeoQuestContext _geoQuestContext;
        public ScoreRepository(GeoQuestContext geoQuestContext)
        {
            _geoQuestContext = geoQuestContext;
        }
        public bool Update(Score score)
        {
            _geoQuestContext.Update(score);
            _geoQuestContext.SaveChanges();
            return true;
        }
        public bool Delete(Score score)
        {
            var scoree = _geoQuestContext.Scores
                .SingleOrDefault(x => x.Users.ScoreId == x.Id);
                
            _geoQuestContext.Scores.Remove(scoree);
            _geoQuestContext.SaveChanges();
            return true;
        }
    }
}
