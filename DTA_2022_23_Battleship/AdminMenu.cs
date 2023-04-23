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
    public partial class AdminMenu : Form {
        private int userId;
        public AdminMenu(int userId) {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnUserManagement_Click(object sender, EventArgs e) {
            this.Hide();
            Program.ShowUserManagement();
        }

        private void btnGame_Click(object sender, EventArgs e) {
            this.Hide();
            Program.StartGame(userId);
        }
    }
}
