namespace DTA_2022_23_Battleship {
    partial class ModificationForm {
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.lblDeactivated = new System.Windows.Forms.Label();
            this.lblBirthyear = new System.Windows.Forms.Label();
            this.txtDeactivated = new System.Windows.Forms.TextBox();
            this.txtIsAdmin = new System.Windows.Forms.TextBox();
            this.txtBirthyear = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(40, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Location = new System.Drawing.Point(40, 98);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(51, 15);
            this.lblIsAdmin.TabIndex = 2;
            this.lblIsAdmin.Text = "IsAdmin";
            // 
            // lblDeactivated
            // 
            this.lblDeactivated.AutoSize = true;
            this.lblDeactivated.Location = new System.Drawing.Point(40, 164);
            this.lblDeactivated.Name = "lblDeactivated";
            this.lblDeactivated.Size = new System.Drawing.Size(69, 15);
            this.lblDeactivated.TabIndex = 3;
            this.lblDeactivated.Text = "Deactivated";
            // 
            // lblBirthyear
            // 
            this.lblBirthyear.AutoSize = true;
            this.lblBirthyear.Location = new System.Drawing.Point(40, 224);
            this.lblBirthyear.Name = "lblBirthyear";
            this.lblBirthyear.Size = new System.Drawing.Size(54, 15);
            this.lblBirthyear.TabIndex = 4;
            this.lblBirthyear.Text = "Birthyear";
            // 
            // txtDeactivated
            // 
            this.txtDeactivated.Location = new System.Drawing.Point(40, 182);
            this.txtDeactivated.Name = "txtDeactivated";
            this.txtDeactivated.Size = new System.Drawing.Size(100, 23);
            this.txtDeactivated.TabIndex = 5;
            // 
            // txtIsAdmin
            // 
            this.txtIsAdmin.Location = new System.Drawing.Point(40, 116);
            this.txtIsAdmin.Name = "txtIsAdmin";
            this.txtIsAdmin.Size = new System.Drawing.Size(100, 23);
            this.txtIsAdmin.TabIndex = 6;
            // 
            // txtBirthyear
            // 
            this.txtBirthyear.Location = new System.Drawing.Point(40, 242);
            this.txtBirthyear.Name = "txtBirthyear";
            this.txtBirthyear.Size = new System.Drawing.Size(100, 23);
            this.txtBirthyear.TabIndex = 7;
            // 
            // txtFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(37, 298);
            this.lblFeedback.Name = "txtFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 15);
            this.lblFeedback.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(40, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtBirthyear);
            this.Controls.Add(this.txtIsAdmin);
            this.Controls.Add(this.txtDeactivated);
            this.Controls.Add(this.lblBirthyear);
            this.Controls.Add(this.lblDeactivated);
            this.Controls.Add(this.lblIsAdmin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "ModificationForm";
            this.Text = "ModificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblIsAdmin;
        private Label lblDeactivated;
        private Label lblBirthyear;
        private TextBox txtDeactivated;
        private TextBox txtIsAdmin;
        private TextBox txtBirthyear;
        private Label lblFeedback;
        private Button btnUpdate;
        private Button btnCancel;
    }
}