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
            this.nameInstructLabel2 = new System.Windows.Forms.Label();
            this.nameInstructLabel1 = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.userTypeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(190, 223);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(207, 23);
            this.userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(190, 360);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(207, 23);
            this.passwordTextBox.TabIndex = 1;
            // 
            // nameInstructLabel2
            // 
            this.nameInstructLabel2.AutoSize = true;
            this.nameInstructLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel2.Location = new System.Drawing.Point(188, 197);
            this.nameInstructLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameInstructLabel2.Name = "nameInstructLabel2";
            this.nameInstructLabel2.Size = new System.Drawing.Size(261, 17);
            this.nameInstructLabel2.TabIndex = 24;
            this.nameInstructLabel2.Text = "It must be between 4 and 15 characters.";
            // 
            // nameInstructLabel1
            // 
            this.nameInstructLabel1.AutoSize = true;
            this.nameInstructLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInstructLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel1.Location = new System.Drawing.Point(188, 181);
            this.nameInstructLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameInstructLabel1.Name = "nameInstructLabel1";
            this.nameInstructLabel1.Size = new System.Drawing.Size(125, 17);
            this.nameInstructLabel1.TabIndex = 21;
            this.nameInstructLabel1.Text = "Enter a username.";
            // 
            // createUserButton
            // 
            this.createUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.Location = new System.Drawing.Point(616, 417);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(98, 32);
            this.createUserButton.TabIndex = 3;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(507, 417);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 32);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userTypeListBox
            // 
            this.userTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeListBox.FormattingEnabled = true;
            this.userTypeListBox.ItemHeight = 17;
            this.userTypeListBox.Location = new System.Drawing.Point(507, 251);
            this.userTypeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.userTypeListBox.Name = "userTypeListBox";
            this.userTypeListBox.Size = new System.Drawing.Size(207, 123);
            this.userTypeListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(504, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Are you a performer or one of our staff?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(504, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Please select one from below.";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordLabel.Location = new System.Drawing.Point(187, 278);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(269, 68);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Enter a password.\r\nIt must be between 4 and 15 characters.\r\nIt must contain 1 low" +
    "ercase, 1 uppercase,\r\nand 1 special character.";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(190, 436);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(206, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(190, 407);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(173, 16);
            this.emailLabel.TabIndex = 33;
            this.emailLabel.Text = "Enter in your email address.";
            // 
            // CreateUserForm
            // 
            this.AcceptButton = this.createUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTypeListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.nameInstructLabel2);
            this.Controls.Add(this.nameInstructLabel1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label nameInstructLabel2;
        private System.Windows.Forms.Label nameInstructLabel1;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox userTypeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
    }
}