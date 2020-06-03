using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3DOK_API.Model
{
    [Table("GameTable")]
    public class GameTable
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("login")]
        public string Login { get; set; }
        [Column("isPublic")]
        public bool IsPublic { get; set; }
        [Column("adress")]
        public string Adress { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("postalCode")]
        public string PostalCode { get; set; }
        [Column("gameDuration")]
        public string GameDuration { get; set; }
        [Column("maxScore")]
        public string MaxScore { get; set; }
        [Column("ownerId")]
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public List<Game> GamesPlayed { get; set; }
    }
}
