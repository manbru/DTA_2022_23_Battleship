using DTA_2022_23_Battleship.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DTA_2022_23_Battleship {
    public partial class LoginScreen : Form {
        public LoginScreen() {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            using (var db = new BattleshipContext()) {
                try {
                    var user = db.Users.Where(u => u.UserName == txtUsername.Text)
                                   .First();
                    if (!user.Deactivated) {
                        if (user.PasswordHash == Cryptography.GenerateHash(txtPassword.Text + user.Salt)) {
                            this.Hide();
                            if (user.IsAdmin) {
                                Program.ShowAdminMenu(user.UserId);
                            } else {
                                Program.StartGame(user.UserId);
                            }
                        } else {
                            lblFeedback.Text = "Incorrect username or password";
                        }
                    } else {
                        lblFeedback.Text = "User is deactivated";
                    }
                } catch {
                    lblFeedback.Text = "Incorrect username or password";
                }
            }
        }
    }
}
