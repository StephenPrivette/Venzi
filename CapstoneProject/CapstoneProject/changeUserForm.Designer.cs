namespace CapstoneProject
{
    partial class ChangeUserForm
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
            this.oldUserLabel = new System.Windows.Forms.Label();
            this.oldUsernameTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextbox = new System.Windows.Forms.TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.newUsernameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oldUserLabel
            // 
            this.oldUserLabel.AutoSize = true;
            this.oldUserLabel.Location = new System.Drawing.Point(29, 20);
            this.oldUserLabel.Name = "oldUserLabel";
            this.oldUserLabel.Size = new System.Drawing.Size(77, 13);
            this.oldUserLabel.TabIndex = 0;
            this.oldUserLabel.Text = "Old Username:";
            // 
            // oldUsernameTextBox
            // 
            this.oldUsernameTextBox.Location = new System.Drawing.Point(32, 36);
            this.oldUsernameTextBox.Name = "oldUsernameTextBox";
            this.oldUsernameTextBox.Size = new System.Drawing.Size(118, 20);
            this.oldUsernameTextBox.TabIndex = 1;
            // 
            // oldPasswordTextbox
            // 
            this.oldPasswordTextbox.Location = new System.Drawing.Point(32, 94);
            this.oldPasswordTextbox.Name = "oldPasswordTextbox";
            this.oldPasswordTextbox.Size = new System.Drawing.Size(118, 20);
            this.oldPasswordTextbox.TabIndex = 3;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Location = new System.Drawing.Point(29, 78);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(75, 13);
            this.oldPasswordLabel.TabIndex = 2;
            this.oldPasswordLabel.Text = "Old Password:";
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Location = new System.Drawing.Point(32, 205);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(118, 20);
            this.newPasswordTextbox.TabIndex = 7;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(29, 189);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.newPasswordLabel.TabIndex = 6;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(47, 231);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(75, 35);
            this.updateInfoButton.TabIndex = 8;
            this.updateInfoButton.Text = "Update Info";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(47, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Location = new System.Drawing.Point(29, 134);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(83, 13);
            this.newUsernameLabel.TabIndex = 4;
            this.newUsernameLabel.Text = "New Username:";
            this.newUsernameLabel.Visible = false;
            // 
            // newUsernameTextbox
            // 
            this.newUsernameTextbox.Location = new System.Drawing.Point(32, 150);
            this.newUsernameTextbox.Name = "newUsernameTextbox";
            this.newUsernameTextbox.Size = new System.Drawing.Size(118, 20);
            this.newUsernameTextbox.TabIndex = 5;
            this.newUsernameTextbox.Visible = false;
            // 
            // ChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 327);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.newPasswordTextbox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newUsernameTextbox);
            this.Controls.Add(this.newUsernameLabel);
            this.Controls.Add(this.oldPasswordTextbox);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.oldUsernameTextBox);
            this.Controls.Add(this.oldUserLabel);
            this.Name = "ChangeUserForm";
            this.Load += new System.EventHandler(this.ChangeUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldUserLabel;
        private System.Windows.Forms.TextBox oldUsernameTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextbox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox newUsernameTextbox;
        private System.Windows.Forms.Label newUsernameLabel;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Button exitButton;
    }
}