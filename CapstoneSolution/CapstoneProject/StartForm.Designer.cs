namespace CapstoneProject
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newUserButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.userInstructionLabel = new System.Windows.Forms.Label();
            this.passwordInstructionLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(374, 206);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(181, 39);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // newUserButton
            // 
            this.newUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.Location = new System.Drawing.Point(352, 389);
            this.newUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(82, 32);
            this.newUserButton.TabIndex = 10;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(352, 299);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(264, 23);
            this.userTextBox.TabIndex = 7;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(532, 389);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(82, 32);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userInstructionLabel
            // 
            this.userInstructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInstructionLabel.AutoSize = true;
            this.userInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInstructionLabel.Location = new System.Drawing.Point(273, 301);
            this.userInstructionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userInstructionLabel.Name = "userInstructionLabel";
            this.userInstructionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userInstructionLabel.Size = new System.Drawing.Size(73, 17);
            this.userInstructionLabel.TabIndex = 12;
            this.userInstructionLabel.Text = "Username";
            // 
            // passwordInstructionLabel
            // 
            this.passwordInstructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordInstructionLabel.AutoSize = true;
            this.passwordInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInstructionLabel.Location = new System.Drawing.Point(275, 336);
            this.passwordInstructionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordInstructionLabel.Name = "passwordInstructionLabel";
            this.passwordInstructionLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordInstructionLabel.TabIndex = 11;
            this.passwordInstructionLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(352, 334);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(264, 23);
            this.passwordTextBox.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userInstructionLabel);
            this.Controls.Add(this.passwordInstructionLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userInstructionLabel;
        private System.Windows.Forms.Label passwordInstructionLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}