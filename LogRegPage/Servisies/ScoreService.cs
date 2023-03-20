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
    public class ScoreService
    {
        private readonly ScoreRepository _scoreRepository;

        public ScoreService(ScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }
        public bool UpdateFlagGame(int score)
        {
            Session.CurrentScore.ScoreGameOne = score;
            Session.CurrentScore.ScoreGameTwo = score;
            return _scoreRepository.Update(Session.CurrentScore);
        }
        public bool UpdateMapGame(int score)
        {
            Session.CurrentScore.ScoreGameTwo = score;
            return _scoreRepository.Update(Session.CurrentScore);
        }
        public bool Delete(Score score)
        {
            return _scoreRepository.Delete(Session.CurrentScore);
        }
    }
}
