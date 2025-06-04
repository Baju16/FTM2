using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FTM2.Models
{
    public class Player
    {
        public int id { get; set; }

        [Required, MaxLength(100)]
        public required string firstname { get; set; }

        [Required, MaxLength(100)]
        public required string lastname { get; set; }

        public required int age { get; set; }

        [MaxLength(50)]
        public required string position { get; set; }

        [MaxLength(50)]
        public required string nationality { get; set; }

        public required int jerseynumber { get; set; }

        public required int teamid { get; set; }
        public required Team team { get; set; }

        public PlayerContract? PlayerContract { get; set; }
    }
}
