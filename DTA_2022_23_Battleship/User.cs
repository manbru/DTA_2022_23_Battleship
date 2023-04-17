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
    }
}
