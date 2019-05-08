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
            this.createUserButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.userTypeListBox = new System.Windows.Forms.ListBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lastTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.userTextBox.Location = new System.Drawing.Point(176, 270);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(340, 30);
            this.userTextBox.TabIndex = 1;
            this.userTextBox.Text = "Username";
            this.userTextBox.Enter += new System.EventHandler(this.userTextBox_Enter);
            this.userTextBox.Leave += new System.EventHandler(this.userTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(176, 540);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(340, 30);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // createUserButton
            // 
            this.createUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.ForeColor = System.Drawing.Color.White;
            this.createUserButton.Location = new System.Drawing.Point(861, 475);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(131, 39);
            this.createUserButton.TabIndex = 7;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(652, 475);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 39);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userTypeListBox
            // 
            this.userTypeListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTypeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userTypeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTypeListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeListBox.ForeColor = System.Drawing.Color.White;
            this.userTypeListBox.FormattingEnabled = true;
            this.userTypeListBox.ItemHeight = 23;
            this.userTypeListBox.Location = new System.Drawing.Point(652, 270);
            this.userTypeListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTypeListBox.Name = "userTypeListBox";
            this.userTypeListBox.Size = new System.Drawing.Size(340, 140);
            this.userTypeListBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.emailTextBox.Location = new System.Drawing.Point(176, 630);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(340, 30);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Text = "Email Address";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(316, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 20);
            this.label14.TabIndex = 78;
            this.label14.Text = "(6 to 40 characters)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "(1 lower, 1 upper, 1 special, 6 to 40 characters)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(316, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "(1 to 40 characters)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(792, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "(pick one)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(391, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 65);
            this.label8.TabIndex = 89;
            this.label8.Text = "Create New User";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(316, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 91;
            this.label9.Text = "(1 to 40 characters)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.firstTextBox.Location = new System.Drawing.Point(176, 360);
            this.firstTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(340, 30);
            this.firstTextBox.TabIndex = 2;
            this.firstTextBox.Text = "First Name";
            this.firstTextBox.Enter += new System.EventHandler(this.firstTextBox_Enter);
            this.firstTextBox.Leave += new System.EventHandler(this.firstTextBox_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(316, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "(1 to 40 characters)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lastTextBox
            // 
            this.lastTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lastTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.lastTextBox.Location = new System.Drawing.Point(176, 450);
            this.lastTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastTextBox.Name = "lastTextBox";
            this.lastTextBox.Size = new System.Drawing.Size(340, 30);
            this.lastTextBox.TabIndex = 3;
            this.lastTextBox.Text = "Last Name";
            this.lastTextBox.Enter += new System.EventHandler(this.lastTextBox_Enter);
            this.lastTextBox.Leave += new System.EventHandler(this.lastTextBox_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(652, 221);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(340, 27);
            this.label12.TabIndex = 95;
            this.label12.Text = "User Type";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateUserForm
            // 
            this.AcceptButton = this.createUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lastTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.userTypeListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox userTypeListBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lastTextBox;
        private System.Windows.Forms.Label label12;
    }
}