using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FTM2.Models
{
    public class PlayerContract
    {
        [Key]
        public int id { get; set; }

        public int playerid { get; set; }
        public required Player Player { get; set; }

        public DateTime startdate { get; set; }
        public DateTime? enddate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? salary { get; set; }
    }
}
