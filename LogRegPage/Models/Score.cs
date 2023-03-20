using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegPage.Models
{
    public partial class Score
    {
        
        public int Id { get; set; }
        public int ScoreGameOne { get; set; }
        public int ScoreGameTwo { get; set; }

        //Navigations
        public User User { get; set; }
    }
}
