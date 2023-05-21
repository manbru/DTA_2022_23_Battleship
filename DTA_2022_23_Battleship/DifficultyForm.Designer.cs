namespace DTA_2022_23_Battleship {
    partial class DifficultyForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnVeryHard = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(65, 40);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(75, 14);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(55, 15);
            this.lblDifficulty.TabIndex = 1;
            this.lblDifficulty.Text = "Difficulty";
            this.lblDifficulty.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(65, 69);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnVeryHard
            // 
            this.btnVeryHard.Location = new System.Drawing.Point(65, 127);
            this.btnVeryHard.Name = "btnVeryHard";
            this.btnVeryHard.Size = new System.Drawing.Size(75, 23);
            this.btnVeryHard.TabIndex = 3;
            this.btnVeryHard.Text = "Very Hard";
            this.btnVeryHard.UseVisualStyleBackColor = true;
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(65, 98);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 4;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 165);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnVeryHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.btnEasy);
            this.Name = "DifficultyForm";
            this.Text = "DifficultyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEasy;
        private Label lblDifficulty;
        private Button btnMedium;
        private Button btnVeryHard;
        private Button btnHard;
    }
}