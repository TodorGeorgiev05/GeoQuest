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
        public Score FindScoreByUserId(int userId)
        {
            return _geoQuestContext.Scores
                .FirstOrDefault(x => x.Id == userId);
        }
        public bool Delete(Score score)
        {
            _geoQuestContext.Scores.Remove(score);
            _geoQuestContext.SaveChanges();
            return true;
        }

        public void Add(Score score)
        {
            _geoQuestContext.Scores.Add(score);
            _geoQuestContext.SaveChanges();
        }
    }
}
