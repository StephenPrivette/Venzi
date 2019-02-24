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
            this.newUserButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.changeUserInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUserButton
            // 
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.Location = new System.Drawing.Point(39, 69);
            this.newUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(68, 73);
            this.newUserButton.TabIndex = 0;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(222, 69);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(68, 73);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(98, 26);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(118, 26);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // changeUserInfo
            // 
            this.changeUserInfo.Location = new System.Drawing.Point(128, 69);
            this.changeUserInfo.Name = "changeUserInfo";
            this.changeUserInfo.Size = new System.Drawing.Size(69, 73);
            this.changeUserInfo.TabIndex = 3;
            this.changeUserInfo.Text = "Change User Information";
            this.changeUserInfo.UseVisualStyleBackColor = true;
            this.changeUserInfo.Click += new System.EventHandler(this.changeUserInfo_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 206);
            this.Controls.Add(this.changeUserInfo);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.newUserButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartForm";
            this.Text = "Convention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button changeUserInfo;
    }
}