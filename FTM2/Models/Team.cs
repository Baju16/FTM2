using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Text.RegularExpressions;

namespace FTM2.Models
{
    public class Team
    {
        [Key]
        public int id { get; set; }

        [Required, MaxLength(100)]
        public required string name { get; set; }

        [MaxLength(100)]
        public required string coach { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal? budget { get; set; }

        [MaxLength(100)]
        public required string league { get; set; }

        public required ICollection<Player> Players { get; set; }
        public required ICollection<Match> HomeMatches { get; set; }
        public required ICollection<Match> AwayMatches { get; set; }
    }
}
