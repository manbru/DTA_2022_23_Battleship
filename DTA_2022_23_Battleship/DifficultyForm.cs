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
    public partial class DifficultyForm : Form {
        private int userId;
        public DifficultyForm(int userId) {
            InitializeComponent();
            this.userId = userId;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnEasy_Click(object sender, EventArgs e) {
            this.Hide();
            Program.StartGame(this.userId);
        }
    }
}
