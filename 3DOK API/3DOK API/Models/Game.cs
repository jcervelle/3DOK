using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3DOK_API.Model
{
    [Table("Game")]
    public class Game
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("playerOneId")]
        public int PlayerOneId { get; set; }
        [Column("playerTwoId")]
        public int PlayerTwoId { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("scorePlayerOne")]
        public int ScorePlayerOne { get; set; }
        [Column("scorePlayerTwo")]
        public int ScorePlayerTwo { get; set; }


        [ForeignKey("PlayerOneId")]
        public virtual User PlayerOne { get; set; }
        [ForeignKey("PlayerTwoId")]
        public virtual User PlayerTwo { get; set; }
    }
}
