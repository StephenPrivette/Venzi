namespace CapstoneProject
{
    partial class AssignmentForm
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
            this.label23 = new System.Windows.Forms.Label();
            this.eventsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.setupColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.breakdownColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requiredColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assignedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.allStaffComboBox = new System.Windows.Forms.ComboBox();
            this.assignedStaffComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(926, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 20);
            this.label23.TabIndex = 102;
            this.label23.Text = "(order by)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // eventsComboBox
            // 
            this.eventsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eventsComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsComboBox.ForeColor = System.Drawing.Color.White;
            this.eventsComboBox.FormattingEnabled = true;
            this.eventsComboBox.Items.AddRange(new object[] {
            "Time",
            "Type",
            "Location"});
            this.eventsComboBox.Location = new System.Drawing.Point(938, 59);
            this.eventsComboBox.Name = "eventsComboBox";
            this.eventsComboBox.Size = new System.Drawing.Size(188, 31);
            this.eventsComboBox.TabIndex = 101;
            this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 38);
            this.label4.TabIndex = 99;
            this.label4.Text = "Staff Assignment";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(259, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 28);
            this.label12.TabIndex = 98;
            this.label12.Text = "Event Schedule";
            // 
            // eventsListView
            // 
            this.eventsListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eventsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.setupColumnHeader,
            this.startColumnHeader,
            this.endColumnHeader,
            this.breakdownColumnHeader,
            this.titleColumnHeader,
            this.typeColumnHeader,
            this.locationColumnHeader,
            this.requiredColumnHeader,
            this.assignedColumnHeader});
            this.eventsListView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsListView.ForeColor = System.Drawing.Color.White;
            this.eventsListView.FullRowSelect = true;
            this.eventsListView.HideSelection = false;
            this.eventsListView.Location = new System.Drawing.Point(53, 95);
            this.eventsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(1073, 230);
            this.eventsListView.TabIndex = 97;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.View = System.Windows.Forms.View.Details;
            this.eventsListView.SelectedIndexChanged += new System.EventHandler(this.eventsListView_SelectedIndexChanged);
            // 
            // setupColumnHeader
            // 
            this.setupColumnHeader.Text = "Setup Start";
            this.setupColumnHeader.Width = 120;
            // 
            // startColumnHeader
            // 
            this.startColumnHeader.Text = "Event Start";
            this.startColumnHeader.Width = 90;
            // 
            // endColumnHeader
            // 
            this.endColumnHeader.Text = "Event End";
            this.endColumnHeader.Width = 90;
            // 
            // breakdownColumnHeader
            // 
            this.breakdownColumnHeader.Text = "Breakdown End";
            this.breakdownColumnHeader.Width = 90;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            this.titleColumnHeader.Width = 120;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 100;
            // 
            // locationColumnHeader
            // 
            this.locationColumnHeader.Text = "Location";
            this.locationColumnHeader.Width = 100;
            // 
            // requiredColumnHeader
            // 
            this.requiredColumnHeader.Text = "Staff Required";
            this.requiredColumnHeader.Width = 100;
            // 
            // assignedColumnHeader
            // 
            this.assignedColumnHeader.Text = "Staff Assigned";
            this.assignedColumnHeader.Width = 100;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(12, 424);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(232, 28);
            this.label7.TabIndex = 105;
            this.label7.Text = "Staff Assigned to Event";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "(pick one to assign to selected event and to see work schedule)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // assignButton
            // 
            this.assignButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.assignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignButton.ForeColor = System.Drawing.Color.White;
            this.assignButton.Location = new System.Drawing.Point(754, 355);
            this.assignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(133, 40);
            this.assignButton.TabIndex = 106;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(926, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "(order by)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // staffComboBox
            // 
            this.staffComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.staffComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffComboBox.ForeColor = System.Drawing.Color.White;
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Items.AddRange(new object[] {
            "Time"});
            this.staffComboBox.Location = new System.Drawing.Point(938, 476);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(188, 31);
            this.staffComboBox.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(411, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 28);
            this.label3.TabIndex = 108;
            this.label3.Text = "Selected Staff\'s Work Schedule";
            // 
            // staffListView
            // 
            this.staffListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.staffListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.staffListView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffListView.ForeColor = System.Drawing.Color.White;
            this.staffListView.FullRowSelect = true;
            this.staffListView.HideSelection = false;
            this.staffListView.Location = new System.Drawing.Point(53, 512);
            this.staffListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffListView.Name = "staffListView";
            this.staffListView.Size = new System.Drawing.Size(1073, 230);
            this.staffListView.TabIndex = 107;
            this.staffListView.UseCompatibleStateImageBehavior = false;
            this.staffListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Setup Start";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Event Start";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Event End";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Breakdown End";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Location";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Staff Required";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Staff Assigned";
            this.columnHeader9.Width = 100;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(122, 367);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 113;
            this.label5.Text = "All Staff";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(334, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "(pick one to remove from selected event)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(754, 412);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(133, 40);
            this.removeButton.TabIndex = 114;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(993, 382);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 40);
            this.exitButton.TabIndex = 115;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // allStaffComboBox
            // 
            this.allStaffComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allStaffComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.allStaffComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStaffComboBox.ForeColor = System.Drawing.Color.White;
            this.allStaffComboBox.FormattingEnabled = true;
            this.allStaffComboBox.Location = new System.Drawing.Point(250, 367);
            this.allStaffComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allStaffComboBox.Name = "allStaffComboBox";
            this.allStaffComboBox.Size = new System.Drawing.Size(468, 28);
            this.allStaffComboBox.TabIndex = 116;
            this.allStaffComboBox.SelectedIndexChanged += new System.EventHandler(this.allStaffComboBox_SelectedIndexChanged);
            // 
            // assignedStaffComboBox
            // 
            this.assignedStaffComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignedStaffComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.assignedStaffComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedStaffComboBox.ForeColor = System.Drawing.Color.White;
            this.assignedStaffComboBox.FormattingEnabled = true;
            this.assignedStaffComboBox.Location = new System.Drawing.Point(250, 424);
            this.assignedStaffComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignedStaffComboBox.Name = "assignedStaffComboBox";
            this.assignedStaffComboBox.Size = new System.Drawing.Size(468, 28);
            this.assignedStaffComboBox.TabIndex = 117;
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.assignedStaffComboBox);
            this.Controls.Add(this.allStaffComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffListView);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.eventsComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.eventsListView);
            this.Name = "AssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Assignment";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox eventsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.ColumnHeader setupColumnHeader;
        private System.Windows.Forms.ColumnHeader startColumnHeader;
        private System.Windows.Forms.ColumnHeader endColumnHeader;
        private System.Windows.Forms.ColumnHeader breakdownColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader locationColumnHeader;
        private System.Windows.Forms.ColumnHeader requiredColumnHeader;
        private System.Windows.Forms.ColumnHeader assignedColumnHeader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView staffListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox allStaffComboBox;
        private System.Windows.Forms.ComboBox assignedStaffComboBox;
    }
}