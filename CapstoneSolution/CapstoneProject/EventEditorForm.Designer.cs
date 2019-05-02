namespace CapstoneProject
{
    partial class EventEditorForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.setupColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.breakdownColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userInstructionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.eventTypeListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.eventDurationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.setupDurationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.breakdownDurationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.eventsComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.staffRequiredTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.requiredColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assignedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(100, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 23);
            this.label12.TabIndex = 51;
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
            this.eventsListView.Location = new System.Drawing.Point(56, 69);
            this.eventsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(900, 230);
            this.eventsListView.TabIndex = 50;
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(465, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 38);
            this.label4.TabIndex = 55;
            this.label4.Text = "Event Editor";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(133, 341);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(351, 30);
            this.nameTextBox.TabIndex = 52;
            // 
            // userInstructionLabel
            // 
            this.userInstructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInstructionLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userInstructionLabel.Location = new System.Drawing.Point(11, 341);
            this.userInstructionLabel.Name = "userInstructionLabel";
            this.userInstructionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userInstructionLabel.Size = new System.Drawing.Size(115, 27);
            this.userInstructionLabel.TabIndex = 54;
            this.userInstructionLabel.Text = "Name";
            this.userInstructionLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "(pick one)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // startTimePicker1
            // 
            this.startTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.startTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.startTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.startTimePicker1.CustomFormat = "";
            this.startTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker1.Location = new System.Drawing.Point(741, 342);
            this.startTimePicker1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.startTimePicker1.Name = "startTimePicker1";
            this.startTimePicker1.Size = new System.Drawing.Size(351, 30);
            this.startTimePicker1.TabIndex = 60;
            this.startTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // eventTypeListBox
            // 
            this.eventTypeListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventTypeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eventTypeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventTypeListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTypeListBox.ForeColor = System.Drawing.Color.White;
            this.eventTypeListBox.FormattingEnabled = true;
            this.eventTypeListBox.ItemHeight = 23;
            this.eventTypeListBox.Location = new System.Drawing.Point(133, 408);
            this.eventTypeListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventTypeListBox.Name = "eventTypeListBox";
            this.eventTypeListBox.Size = new System.Drawing.Size(351, 140);
            this.eventTypeListBox.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(11, 408);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(115, 27);
            this.label7.TabIndex = 65;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "(4 to 30 characters)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(576, 341);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 67;
            this.label3.Text = "Start Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(11, 590);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 70;
            this.label5.Text = "Location";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // locationListBox
            // 
            this.locationListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.locationListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListBox.ForeColor = System.Drawing.Color.White;
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 23;
            this.locationListBox.Location = new System.Drawing.Point(133, 590);
            this.locationListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(351, 140);
            this.locationListBox.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(283, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "(pick one)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(576, 436);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(158, 27);
            this.label8.TabIndex = 72;
            this.label8.Text = "Event Duration";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // startTimePicker2
            // 
            this.startTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker2.CalendarForeColor = System.Drawing.Color.Black;
            this.startTimePicker2.CalendarMonthBackground = System.Drawing.Color.White;
            this.startTimePicker2.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.startTimePicker2.CustomFormat = "h:mm tt";
            this.startTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker2.Location = new System.Drawing.Point(741, 379);
            this.startTimePicker2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.startTimePicker2.Name = "startTimePicker2";
            this.startTimePicker2.ShowUpDown = true;
            this.startTimePicker2.Size = new System.Drawing.Size(351, 30);
            this.startTimePicker2.TabIndex = 73;
            this.startTimePicker2.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(576, 500);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(158, 27);
            this.label9.TabIndex = 75;
            this.label9.Text = "Setup Duration";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(891, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 20);
            this.label10.TabIndex = 77;
            this.label10.Text = "(select a date and time)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(641, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "(hours and minutes)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(641, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 20);
            this.label13.TabIndex = 79;
            this.label13.Text = "(hours and minutes)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(641, 545);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 20);
            this.label14.TabIndex = 82;
            this.label14.Text = "(hours and minutes)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(517, 565);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(218, 27);
            this.label15.TabIndex = 80;
            this.label15.Text = "Breakdown Duration";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(741, 629);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(351, 105);
            this.descriptionRichTextBox.TabIndex = 84;
            this.descriptionRichTextBox.Text = "";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(859, 606);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 20);
            this.label16.TabIndex = 85;
            this.label16.Text = "(4 to 400 characters)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.Location = new System.Drawing.Point(561, 626);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(173, 27);
            this.label17.TabIndex = 86;
            this.label17.Text = "Description";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(993, 239);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 60);
            this.saveButton.TabIndex = 87;
            this.saveButton.Text = "Save Event";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(993, 175);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(149, 60);
            this.clearButton.TabIndex = 88;
            this.clearButton.Text = "Clear Entry";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(993, 47);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 60);
            this.exitButton.TabIndex = 89;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(232, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 20);
            this.label18.TabIndex = 90;
            this.label18.Text = "(select event to edit)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // eventDurationTextBox
            // 
            this.eventDurationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventDurationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eventDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventDurationTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDurationTextBox.ForeColor = System.Drawing.Color.White;
            this.eventDurationTextBox.Location = new System.Drawing.Point(741, 439);
            this.eventDurationTextBox.Mask = "90:00";
            this.eventDurationTextBox.Name = "eventDurationTextBox";
            this.eventDurationTextBox.Size = new System.Drawing.Size(132, 30);
            this.eventDurationTextBox.TabIndex = 91;
            this.eventDurationTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // setupDurationTextBox
            // 
            this.setupDurationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setupDurationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.setupDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setupDurationTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupDurationTextBox.ForeColor = System.Drawing.Color.White;
            this.setupDurationTextBox.Location = new System.Drawing.Point(741, 503);
            this.setupDurationTextBox.Mask = "90:00";
            this.setupDurationTextBox.Name = "setupDurationTextBox";
            this.setupDurationTextBox.Size = new System.Drawing.Size(132, 30);
            this.setupDurationTextBox.TabIndex = 92;
            this.setupDurationTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // breakdownDurationTextBox
            // 
            this.breakdownDurationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breakdownDurationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.breakdownDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breakdownDurationTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdownDurationTextBox.ForeColor = System.Drawing.Color.White;
            this.breakdownDurationTextBox.Location = new System.Drawing.Point(741, 568);
            this.breakdownDurationTextBox.Mask = "90:00";
            this.breakdownDurationTextBox.Name = "breakdownDurationTextBox";
            this.breakdownDurationTextBox.Size = new System.Drawing.Size(132, 30);
            this.breakdownDurationTextBox.TabIndex = 93;
            this.breakdownDurationTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(993, 111);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 60);
            this.deleteButton.TabIndex = 94;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(756, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 20);
            this.label23.TabIndex = 96;
            this.label23.Text = "(order by)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // eventsComboBox
            // 
            this.eventsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eventsComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsComboBox.ForeColor = System.Drawing.Color.White;
            this.eventsComboBox.FormattingEnabled = true;
            this.eventsComboBox.Items.AddRange(new object[] {
            "Time",
            "Type",
            "Location"});
            this.eventsComboBox.Location = new System.Drawing.Point(768, 33);
            this.eventsComboBox.Name = "eventsComboBox";
            this.eventsComboBox.Size = new System.Drawing.Size(188, 31);
            this.eventsComboBox.TabIndex = 95;
            this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(912, 453);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(166, 27);
            this.label19.TabIndex = 97;
            this.label19.Text = "Staff Required";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // staffRequiredTextBox
            // 
            this.staffRequiredTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffRequiredTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.staffRequiredTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffRequiredTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffRequiredTextBox.ForeColor = System.Drawing.Color.White;
            this.staffRequiredTextBox.Location = new System.Drawing.Point(960, 503);
            this.staffRequiredTextBox.Mask = "990";
            this.staffRequiredTextBox.Name = "staffRequiredTextBox";
            this.staffRequiredTextBox.Size = new System.Drawing.Size(132, 30);
            this.staffRequiredTextBox.TabIndex = 99;
            this.staffRequiredTextBox.ValidatingType = typeof(int);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(860, 480);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 20);
            this.label20.TabIndex = 98;
            this.label20.Text = "(1 - 999)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // EventEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.staffRequiredTextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.eventsComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.breakdownDurationTextBox);
            this.Controls.Add(this.setupDurationTextBox);
            this.Controls.Add(this.eventDurationTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eventTypeListBox);
            this.Controls.Add(this.startTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.userInstructionLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.eventsListView);
            this.Name = "EventEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Editor";
            this.Load += new System.EventHandler(this.EventEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.ColumnHeader startColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader locationColumnHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label userInstructionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startTimePicker1;
        private System.Windows.Forms.ListBox eventTypeListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker startTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox eventDurationTextBox;
        private System.Windows.Forms.MaskedTextBox setupDurationTextBox;
        private System.Windows.Forms.MaskedTextBox breakdownDurationTextBox;
        private System.Windows.Forms.ColumnHeader setupColumnHeader;
        private System.Windows.Forms.ColumnHeader breakdownColumnHeader;
        private System.Windows.Forms.ColumnHeader endColumnHeader;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox eventsComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox staffRequiredTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ColumnHeader requiredColumnHeader;
        private System.Windows.Forms.ColumnHeader assignedColumnHeader;
    }
}