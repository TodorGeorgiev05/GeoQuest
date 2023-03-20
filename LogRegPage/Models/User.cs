using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogRegPage.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
        public string Grade { get; set; }

        // Navigations
        
        public int ScoreId { get; set; }
        public Score HighScore { get; set; }
    }

}
