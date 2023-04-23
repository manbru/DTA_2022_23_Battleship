using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DTA_2022_23_Battleship {
    public class User {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public bool IsAdmin { get; set; }
        public bool Deactivated { get; set; }
        public int BirthYear { get; set; }
        public List<Match> Matches { get; set; }
    }
}
