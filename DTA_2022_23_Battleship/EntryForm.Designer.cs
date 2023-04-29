namespace DTA_2022_23_Battleship {
    partial class Entry {
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
            this.txtIsAdmin = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.lblBirthyear = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBirthyear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(67, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // txtIsAdmin
            // 
            this.txtIsAdmin.Location = new System.Drawing.Point(67, 178);
            this.txtIsAdmin.Name = "txtIsAdmin";
            this.txtIsAdmin.Size = new System.Drawing.Size(100, 23);
            this.txtIsAdmin.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(67, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(67, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Location = new System.Drawing.Point(67, 160);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(51, 15);
            this.lblIsAdmin.TabIndex = 4;
            this.lblIsAdmin.Text = "IsAdmin";
            // 
            // lblBirthyear
            // 
            this.lblBirthyear.AutoSize = true;
            this.lblBirthyear.Location = new System.Drawing.Point(67, 225);
            this.lblBirthyear.Name = "lblBirthyear";
            this.lblBirthyear.Size = new System.Drawing.Size(54, 15);
            this.lblBirthyear.TabIndex = 5;
            this.lblBirthyear.Text = "Birthyear";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(67, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // txtBirthyear
            // 
            this.txtBirthyear.Location = new System.Drawing.Point(67, 243);
            this.txtBirthyear.Name = "txtBirthyear";
            this.txtBirthyear.Size = new System.Drawing.Size(100, 23);
            this.txtBirthyear.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(67, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(148, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(67, 292);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 15);
            this.lblFeedback.TabIndex = 10;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBirthyear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblBirthyear);
            this.Controls.Add(this.lblIsAdmin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtIsAdmin);
            this.Controls.Add(this.txtUsername);
            this.Name = "Entry";
            this.Text = "Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtIsAdmin;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblIsAdmin;
        private Label lblBirthyear;
        private TextBox txtPassword;
        private TextBox txtBirthyear;
        private Button btnAdd;
        private Button btnCancel;
        private Label lblFeedback;
    }
}