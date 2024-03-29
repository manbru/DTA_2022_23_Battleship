﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTA_2022_23_Battleship {
    public partial class PlayersForm : Form {
        private int userId;
        public PlayersForm(int userId) {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e) {
            this.Hide();
            Program.ShowDifficultyForm(userId);
        }
    }
}
