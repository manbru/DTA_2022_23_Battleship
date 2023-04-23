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
using System.Security.Cryptography;
using System.Diagnostics;

namespace DTA_2022_23_Battleship {
    public partial class LoginScreen : Form {
        public LoginScreen() {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            using (var db = new BattleshipContext()) {
                var user = db.Users.Where(u => u.UserName == txtUsername.Text)
                                   .First();
                if (!user.Deactivated) {
                    if (user.PasswordHash == ComputeSha256Hash(txtPassword.Text + user.Salt)) {
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
                
            }
        }
        private static string ComputeSha256Hash(string rawData) {
            using (var sha256Hash = SHA256.Create()) {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
