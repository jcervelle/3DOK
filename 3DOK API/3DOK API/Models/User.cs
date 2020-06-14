using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3DOK_API.Model
{
    [Table("User")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("firstname")]
        public string Firstname { get; set; }
        [Column("lastname")]
        public string Lastname { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("birthDate")]
        public DateTime BirthDate { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        public virtual List<Game> PlayedGamesAsPlayerOne { get; set; }
        public virtual List<Game> PlayedGamesAsPlayerTwo { get; set; }
        public virtual List<GameTable> OwnedTables { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
