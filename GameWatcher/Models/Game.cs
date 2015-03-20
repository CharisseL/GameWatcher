using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GameWatcher.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set;}
        public int AwayScore { get; set; }
        public int HomeScore { get; set; }
        public Channel Channel { get; set; }
    }
}