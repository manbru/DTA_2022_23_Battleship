using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DTA_2022_23_Battleship {
    public partial class ModificationForm : Form {
        User currentUser;
        public ModificationForm(User currentUser) {
            InitializeComponent();
            this.currentUser = currentUser;
            txtUsername.Text = currentUser.UserName;
            txtIsAdmin.Text = currentUser.IsAdmin.ToString();
            txtDeactivated.Text = currentUser.Deactivated.ToString();
            txtBirthyear.Text = currentUser.BirthYear.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            try {
                bool isAdmin = bool.Parse(txtIsAdmin.Text);
                bool deactivated = bool.Parse(txtIsAdmin.Text);
                int birthyear = int.Parse(txtBirthyear.Text);
                using (var db = new BattleshipContext()) {
                    currentUser.UserName = txtUsername.Text;
                    currentUser.IsAdmin = isAdmin;
                    currentUser.Deactivated = deactivated;
                    currentUser.BirthYear = birthyear;
                    db.Users.Update(currentUser);
                    
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
