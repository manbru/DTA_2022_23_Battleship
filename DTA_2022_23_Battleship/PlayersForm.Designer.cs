namespace DTA_2022_23_Battleship {
    partial class PlayersForm {
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
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(40, 40);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(125, 23);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(40, 100);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(125, 23);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 165);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Name = "PlayersForm";
            this.Text = "PlayersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSinglePlayer;
        private Button btnMultiplayer;
    }
}