using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TOB.Models.Entity;

namespace TOB.Models.Game
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
    }
}
