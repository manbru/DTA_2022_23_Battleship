using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTA_2022_23_Battleship {
    public partial class Entry : Form {
        public Entry() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            try {
                bool isAdmin = bool.Parse(txtIsAdmin.Text);
                int birthyear = int.Parse(txtBirthyear.Text);
                string salt = Cryptography.GenerateSalt();
                using (var db = new BattleshipContext()) {
                    db.Users.Add(new User() {
                        UserId = db.Users.Count(),
                        UserName = txtUsername.Text,
                        PasswordHash = Cryptography.GenerateHash(txtPassword.Text + salt),
                        Salt = salt,
                        IsAdmin = isAdmin,
                        Deactivated = false,
                        BirthYear = birthyear,
                        Matches = new List<Match>()
                    });
                    db.SaveChanges();
                    this.Hide();
                    Program.ShowUserManagement();
                }
            } catch {
                lblFeedback.Text = "Incorrect input";
            }
        }
    }
}
