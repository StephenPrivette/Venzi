namespace CapstoneProject
{
    partial class CreateUserForm
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
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passInstructLabel3 = new System.Windows.Forms.Label();
            this.nameInstructLabel2 = new System.Windows.Forms.Label();
            this.passInstructLabel2 = new System.Windows.Forms.Label();
            this.passInstructLabel1 = new System.Windows.Forms.Label();
            this.nameInstructLabel1 = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(40, 69);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(146, 22);
            this.userTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(40, 194);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(146, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // passInstructLabel3
            // 
            this.passInstructLabel3.AutoSize = true;
            this.passInstructLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel3.Location = new System.Drawing.Point(37, 174);
            this.passInstructLabel3.Name = "passInstructLabel3";
            this.passInstructLabel3.Size = new System.Drawing.Size(283, 17);
            this.passInstructLabel3.TabIndex = 25;
            this.passInstructLabel3.Text = "1 uppercase letter, and 1 special character.";
            // 
            // nameInstructLabel2
            // 
            this.nameInstructLabel2.AutoSize = true;
            this.nameInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel2.Location = new System.Drawing.Point(37, 49);
            this.nameInstructLabel2.Name = "nameInstructLabel2";
            this.nameInstructLabel2.Size = new System.Drawing.Size(252, 17);
            this.nameInstructLabel2.TabIndex = 24;
            this.nameInstructLabel2.Text = "It must be no more than 15 characters.";
            // 
            // passInstructLabel2
            // 
            this.passInstructLabel2.AutoSize = true;
            this.passInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel2.Location = new System.Drawing.Point(37, 157);
            this.passInstructLabel2.Name = "passInstructLabel2";
            this.passInstructLabel2.Size = new System.Drawing.Size(313, 17);
            this.passInstructLabel2.TabIndex = 23;
            this.passInstructLabel2.Text = "10 characters. It must contain 1 lowercase letter,";
            // 
            // passInstructLabel1
            // 
            this.passInstructLabel1.AutoSize = true;
            this.passInstructLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel1.Location = new System.Drawing.Point(37, 140);
            this.passInstructLabel1.Name = "passInstructLabel1";
            this.passInstructLabel1.Size = new System.Drawing.Size(279, 17);
            this.passInstructLabel1.TabIndex = 22;
            this.passInstructLabel1.Text = " Enter a password. It must be no more than";
            // 
            // nameInstructLabel1
            // 
            this.nameInstructLabel1.AutoSize = true;
            this.nameInstructLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel1.Location = new System.Drawing.Point(37, 32);
            this.nameInstructLabel1.Name = "nameInstructLabel1";
            this.nameInstructLabel1.Size = new System.Drawing.Size(125, 17);
            this.nameInstructLabel1.TabIndex = 21;
            this.nameInstructLabel1.Text = "Enter a username.";
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(397, 40);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(75, 51);
            this.createUserButton.TabIndex = 26;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(397, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 30);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.passInstructLabel3);
            this.Controls.Add(this.nameInstructLabel2);
            this.Controls.Add(this.passInstructLabel2);
            this.Controls.Add(this.passInstructLabel1);
            this.Controls.Add(this.nameInstructLabel1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "CreateUserForm";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passInstructLabel3;
        private System.Windows.Forms.Label nameInstructLabel2;
        private System.Windows.Forms.Label passInstructLabel2;
        private System.Windows.Forms.Label passInstructLabel1;
        private System.Windows.Forms.Label nameInstructLabel1;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button exitButton;
    }
}