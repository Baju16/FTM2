using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FTM2.Models
{


    public class Match
    {

        [Key]
        public int id { get; set; }

        public required DateTime matchdate { get; set; }

        public required int hometeamid { get; set; }
        public required Team hometeam { get; set; }

        public required int awayteamid { get; set; }
        public required Team awayteam { get; set; }

        [MaxLength(100)]
        public required string stadium { get; set; }

        [MaxLength(20)]
        public required string result { get; set; }


    }
}
