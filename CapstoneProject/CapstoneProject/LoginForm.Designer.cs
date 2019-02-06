namespace CapstoneProject
{
    partial class LoginForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordInstructionLabel = new System.Windows.Forms.Label();
            this.userInstructionLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(232, 54);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(146, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordInstructionLabel
            // 
            this.passwordInstructionLabel.AutoSize = true;
            this.passwordInstructionLabel.Location = new System.Drawing.Point(273, 34);
            this.passwordInstructionLabel.Name = "passwordInstructionLabel";
            this.passwordInstructionLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordInstructionLabel.TabIndex = 4;
            this.passwordInstructionLabel.Text = "Password";
            // 
            // userInstructionLabel
            // 
            this.userInstructionLabel.AutoSize = true;
            this.userInstructionLabel.Location = new System.Drawing.Point(76, 34);
            this.userInstructionLabel.Name = "userInstructionLabel";
            this.userInstructionLabel.Size = new System.Drawing.Size(73, 17);
            this.userInstructionLabel.TabIndex = 5;
            this.userInstructionLabel.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(268, 120);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(74, 30);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(42, 54);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(146, 22);
            this.userTextBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(75, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 30);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 179);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userInstructionLabel);
            this.Controls.Add(this.passwordInstructionLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordInstructionLabel;
        private System.Windows.Forms.Label userInstructionLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}