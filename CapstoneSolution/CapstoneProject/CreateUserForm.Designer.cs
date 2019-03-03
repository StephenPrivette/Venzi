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
            this.userTypeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(254, 275);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(275, 27);
            this.userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(254, 443);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(275, 27);
            this.passwordTextBox.TabIndex = 1;
            // 
            // passInstructLabel3
            // 
            this.passInstructLabel3.AutoSize = true;
            this.passInstructLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInstructLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel3.Location = new System.Drawing.Point(250, 411);
            this.passInstructLabel3.Name = "passInstructLabel3";
            this.passInstructLabel3.Size = new System.Drawing.Size(188, 20);
            this.passInstructLabel3.TabIndex = 25;
            this.passInstructLabel3.Text = "and 1 special character.";
            // 
            // nameInstructLabel2
            // 
            this.nameInstructLabel2.AutoSize = true;
            this.nameInstructLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel2.Location = new System.Drawing.Point(250, 243);
            this.nameInstructLabel2.Name = "nameInstructLabel2";
            this.nameInstructLabel2.Size = new System.Drawing.Size(308, 20);
            this.nameInstructLabel2.TabIndex = 24;
            this.nameInstructLabel2.Text = "It must be between 4 and 15 characters.";
            // 
            // passInstructLabel2
            // 
            this.passInstructLabel2.AutoSize = true;
            this.passInstructLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel2.Location = new System.Drawing.Point(250, 391);
            this.passInstructLabel2.Name = "passInstructLabel2";
            this.passInstructLabel2.Size = new System.Drawing.Size(319, 20);
            this.passInstructLabel2.TabIndex = 23;
            this.passInstructLabel2.Text = "It must contain 1 lowercase, 1 uppercase,";
            // 
            // passInstructLabel1
            // 
            this.passInstructLabel1.AutoSize = true;
            this.passInstructLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInstructLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel1.Location = new System.Drawing.Point(250, 371);
            this.passInstructLabel1.Name = "passInstructLabel1";
            this.passInstructLabel1.Size = new System.Drawing.Size(308, 20);
            this.passInstructLabel1.TabIndex = 22;
            this.passInstructLabel1.Text = "It must be between 4 and 15 characters.";
            // 
            // nameInstructLabel1
            // 
            this.nameInstructLabel1.AutoSize = true;
            this.nameInstructLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInstructLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel1.Location = new System.Drawing.Point(250, 223);
            this.nameInstructLabel1.Name = "nameInstructLabel1";
            this.nameInstructLabel1.Size = new System.Drawing.Size(146, 20);
            this.nameInstructLabel1.TabIndex = 21;
            this.nameInstructLabel1.Text = "Enter a username.";
            // 
            // createUserButton
            // 
            this.createUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.Location = new System.Drawing.Point(818, 479);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(130, 40);
            this.createUserButton.TabIndex = 3;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(673, 479);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userTypeListBox
            // 
            this.userTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeListBox.FormattingEnabled = true;
            this.userTypeListBox.ItemHeight = 20;
            this.userTypeListBox.Location = new System.Drawing.Point(673, 275);
            this.userTypeListBox.Name = "userTypeListBox";
            this.userTypeListBox.Size = new System.Drawing.Size(275, 164);
            this.userTypeListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(669, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Are you a performer or one of our staff?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(669, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Please select one from below.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(250, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter a password.";
            // 
            // CreateUserForm
            // 
            this.AcceptButton = this.createUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTypeListBox);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
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
        private System.Windows.Forms.ListBox userTypeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}