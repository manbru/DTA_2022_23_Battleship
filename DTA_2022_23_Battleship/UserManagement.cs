using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DTA_2022_23_Battleship {
    public partial class UserManagement : Form {
        public User? CurrentUser => (gridUsers.CurrentRow != null) ? gridUsers.CurrentRow.DataBoundItem as User : null;
        public UserManagement() {
            InitializeComponent();
            DisplayUsers();
            DisplayMatches(CurrentUser);
        }
        private void DisplayUsers() {
            gridUsers.DataSource = GetUsers();
            gridUsers.Columns["UserId"].Visible= false;
            gridUsers.Columns["Salt"].Visible = false;
            gridUsers.Columns["PasswordHash"].Visible = false;
        }
        private void DisplayMatches(User user) {
            gridMatches.DataSource = GetMatches(user);
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
            using (var db = new BattleshipContext()) {
                if (user == null) {
                    return Enumerable.Empty<Match>();
                } else {
                    return db.Matches.Select(u => new Match() {
                        WinnerName = u.WinnerName,
                        LoserName = u.LoserName,
                        WinnerScore = u.WinnerScore,
                        LoserScore = u.LoserScore,
                        EndTime = u.EndTime,
                        Turns = u.Turns,
                    }).Where(u => u.WinnerName == user.UserName || u.LoserName == user.UserName).ToList();
                }
            }
        }
        private void gridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DisplayMatches(CurrentUser);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var entry = new Entry();
            this.Hide();
            entry.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (CurrentUser != null) {
                this.Hide();
                var modify = new ModificationForm(CurrentUser);
                modify.Show();
            }
        }

        private void btnMatches_Click(object sender, EventArgs e) {
            DisplayMatches(null);
        }
    }
}
