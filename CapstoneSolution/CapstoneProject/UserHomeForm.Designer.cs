namespace CapstoneProject
{
    partial class UserHomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itineraryListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduleListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.signOutButton = new System.Windows.Forms.Button();
            this.passInstructLabel3 = new System.Windows.Forms.Label();
            this.nameInstructLabel2 = new System.Windows.Forms.Label();
            this.passInstructLabel2 = new System.Windows.Forms.Label();
            this.passInstructLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeUsernameTextBox = new System.Windows.Forms.TextBox();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.userInstructionLabel = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(367, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Schedule";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(982, 186);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 60);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Event to Itinerary";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(367, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Itinerary";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.Location = new System.Drawing.Point(982, 544);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 60);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Event From Itinerary";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteItineraryItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 753);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.itineraryListView);
            this.tabPage1.Controls.Add(this.scheduleListView);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule";
            // 
            // itineraryListView
            // 
            this.itineraryListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itineraryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.itineraryListView.FullRowSelect = true;
            this.itineraryListView.GridLines = true;
            this.itineraryListView.Location = new System.Drawing.Point(31, 457);
            this.itineraryListView.Name = "itineraryListView";
            this.itineraryListView.Size = new System.Drawing.Size(900, 230);
            this.itineraryListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.itineraryListView.TabIndex = 6;
            this.itineraryListView.UseCompatibleStateImageBehavior = false;
            this.itineraryListView.View = System.Windows.Forms.View.Details;
            this.itineraryListView.SelectedIndexChanged += new System.EventHandler(this.itineraryListView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Title";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Location";
            this.columnHeader9.Width = 160;
            // 
            // scheduleListView
            // 
            this.scheduleListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scheduleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.scheduleListView.FullRowSelect = true;
            this.scheduleListView.GridLines = true;
            this.scheduleListView.Location = new System.Drawing.Point(31, 103);
            this.scheduleListView.Name = "scheduleListView";
            this.scheduleListView.Size = new System.Drawing.Size(900, 230);
            this.scheduleListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.scheduleListView.TabIndex = 5;
            this.scheduleListView.UseCompatibleStateImageBehavior = false;
            this.scheduleListView.View = System.Windows.Forms.View.Details;
            this.scheduleListView.SelectedIndexChanged += new System.EventHandler(this.scheduleListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Location";
            this.columnHeader4.Width = 160;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.signOutButton);
            this.tabPage2.Controls.Add(this.passInstructLabel3);
            this.tabPage2.Controls.Add(this.nameInstructLabel2);
            this.tabPage2.Controls.Add(this.passInstructLabel2);
            this.tabPage2.Controls.Add(this.passInstructLabel1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.changePasswordTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.changePasswordButton);
            this.tabPage2.Controls.Add(this.changeUsernameTextBox);
            this.tabPage2.Controls.Add(this.changeUsernameButton);
            this.tabPage2.Controls.Add(this.userInstructionLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account";
            // 
            // signOutButton
            // 
            this.signOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.Location = new System.Drawing.Point(1007, 48);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(110, 40);
            this.signOutButton.TabIndex = 39;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // passInstructLabel3
            // 
            this.passInstructLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passInstructLabel3.AutoSize = true;
            this.passInstructLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInstructLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel3.Location = new System.Drawing.Point(474, 475);
            this.passInstructLabel3.Name = "passInstructLabel3";
            this.passInstructLabel3.Size = new System.Drawing.Size(188, 20);
            this.passInstructLabel3.TabIndex = 38;
            this.passInstructLabel3.Text = "and 1 special character.";
            // 
            // nameInstructLabel2
            // 
            this.nameInstructLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameInstructLabel2.AutoSize = true;
            this.nameInstructLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameInstructLabel2.Location = new System.Drawing.Point(474, 185);
            this.nameInstructLabel2.Name = "nameInstructLabel2";
            this.nameInstructLabel2.Size = new System.Drawing.Size(308, 20);
            this.nameInstructLabel2.TabIndex = 37;
            this.nameInstructLabel2.Text = "It must be between 4 and 15 characters.";
            // 
            // passInstructLabel2
            // 
            this.passInstructLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passInstructLabel2.AutoSize = true;
            this.passInstructLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInstructLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel2.Location = new System.Drawing.Point(474, 455);
            this.passInstructLabel2.Name = "passInstructLabel2";
            this.passInstructLabel2.Size = new System.Drawing.Size(319, 20);
            this.passInstructLabel2.TabIndex = 36;
            this.passInstructLabel2.Text = "It must contain 1 lowercase, 1 uppercase,";
            // 
            // passInstructLabel1
            // 
            this.passInstructLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passInstructLabel1.AutoSize = true;
            this.passInstructLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInstructLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passInstructLabel1.Location = new System.Drawing.Point(474, 435);
            this.passInstructLabel1.Name = "passInstructLabel1";
            this.passInstructLabel1.Size = new System.Drawing.Size(308, 20);
            this.passInstructLabel1.TabIndex = 35;
            this.passInstructLabel1.Text = "It must be between 4 and 15 characters.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(515, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Change Password";
            // 
            // changePasswordTextBox
            // 
            this.changePasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changePasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTextBox.Location = new System.Drawing.Point(459, 511);
            this.changePasswordTextBox.Name = "changePasswordTextBox";
            this.changePasswordTextBox.Size = new System.Drawing.Size(350, 27);
            this.changePasswordTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 514);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "New Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(511, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Change Username";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(699, 557);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(110, 40);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Submit";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeUsernameTextBox
            // 
            this.changeUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUsernameTextBox.Location = new System.Drawing.Point(459, 219);
            this.changeUsernameTextBox.Name = "changeUsernameTextBox";
            this.changeUsernameTextBox.Size = new System.Drawing.Size(350, 27);
            this.changeUsernameTextBox.TabIndex = 13;
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeUsernameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUsernameButton.Location = new System.Drawing.Point(699, 268);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(110, 40);
            this.changeUsernameButton.TabIndex = 15;
            this.changeUsernameButton.Text = "Submit";
            this.changeUsernameButton.UseVisualStyleBackColor = true;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // userInstructionLabel
            // 
            this.userInstructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInstructionLabel.AutoSize = true;
            this.userInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInstructionLabel.Location = new System.Drawing.Point(316, 222);
            this.userInstructionLabel.Name = "userInstructionLabel";
            this.userInstructionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userInstructionLabel.Size = new System.Drawing.Size(124, 20);
            this.userInstructionLabel.TabIndex = 18;
            this.userInstructionLabel.Text = "New Username";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Start Time";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 4;
            this.columnHeader10.Text = "Start Time";
            this.columnHeader10.Width = 0;
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.UserHomeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView scheduleListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView itineraryListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changePasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox changeUsernameTextBox;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Label userInstructionLabel;
        private System.Windows.Forms.Label passInstructLabel3;
        private System.Windows.Forms.Label nameInstructLabel2;
        private System.Windows.Forms.Label passInstructLabel2;
        private System.Windows.Forms.Label passInstructLabel1;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}