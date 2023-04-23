using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;

namespace DTA_2022_23_Battleship {
    public partial class UserManagement : Form {
        public User? CurrentUser => (gridUsers.CurrentRow != null) ? gridUsers.CurrentRow.DataBoundItem as User : null;
        public UserManagement() {
            InitializeComponent();
            DisplayUsers();
        }
        private void DisplayUsers() {
            gridUsers.DataSource = GetUsers();
            gridUsers.Columns["UserId"].Visible = false;
            gridUsers.Columns["Salt"].Visible = false;
            gridUsers.Columns["PasswordHash"].Visible = false;
            gridUsers.Columns["UserId"].Visible = false;
        }
        private void DisplayMatches(User user) {
            gridMatches.DataSource = GetMatches(user);
        }
        private void gridUsers_SelectionChanged(object sender, EventArgs e) {
            DisplayMatches(CurrentUser);
        }
        private IEnumerable<User> GetUsers() {
            using (var db = new BattleshipContext()) {
                return db.Users.Select(u => new User() {
                    UserName = u.UserName,
                    BirthYear = u.BirthYear,
                    Deactivated = u.Deactivated,
                    IsAdmin = u.IsAdmin,
                }).ToList();
            }
        }
        private IEnumerable<Match> GetMatches(User user) {
            using ( var db = new BattleshipContext()) {
                return db.Matches.Select(u => new Match() {
                    WinnerName = u.WinnerName,
                    LoserName= u.LoserName,
                    WinnerScore= u.WinnerScore,
                    LoserScore= u.LoserScore,
                    EndTime= u.EndTime,
                    Turns= u.Turns,
                }).Where(u => user.UserName == u.WinnerName || user.UserName == u.LoserName).ToList();
            }
        }
    }
    
}
