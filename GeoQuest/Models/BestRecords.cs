using System.ComponentModel.DataAnnotations;

namespace GeoQuest.Models
{
    internal class BestRecords
    {
        [Key]
        public int Id { get; set; }
        public int HighScore { get; set; }

    }
}