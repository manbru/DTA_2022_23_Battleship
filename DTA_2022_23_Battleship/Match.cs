using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DTA_2022_23_Battleship {
    public class Match {
        public int MatchId { get; set; }
        public int EndTime { get; set; }
        public string WinnerName { get; set; }
        public string LoserName { get; set; }
        public int Turns { get; set; }
        public int WinnerScore { get; set; }
        public int LoserScore { get; set;}
    }
}
