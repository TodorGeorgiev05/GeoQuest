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
        public bool UpdateFlagGame(int score, int userId)
        {
            var foundScore = _scoreRepository.FindScoreByUserId(userId);
            if (foundScore == null)
            {
                return false;
            }
            foundScore.ScoreGameOne = score;
            return _scoreRepository.Update(foundScore);
        }
        public bool UpdateMapGame(int score, int userId)
        {
            var foundScore = _scoreRepository.FindScoreByUserId(userId);
            if (foundScore == null)
            {
                return false;
            }
            foundScore.ScoreGameTwo = score;
            return _scoreRepository.Update(foundScore);
        }
        public bool Delete(Score score)
        {
            var foundScore =_scoreRepository.FindScoreByUserId(score.User.Id);
            if (foundScore == null)
            {
                return false;
            }
            return _scoreRepository.Delete(foundScore);
        }
    }
}
