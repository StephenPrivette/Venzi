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
            this.scheduleListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.itineraryListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Schedule";
            // 
            // scheduleListBox
            // 
            this.scheduleListBox.FormattingEnabled = true;
            this.scheduleListBox.ItemHeight = 16;
            this.scheduleListBox.Location = new System.Drawing.Point(51, 60);
            this.scheduleListBox.Name = "scheduleListBox";
            this.scheduleListBox.Size = new System.Drawing.Size(650, 228);
            this.scheduleListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(95, 319);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 49);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add to Itinerary";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itineraryListBox
            // 
            this.itineraryListBox.FormattingEnabled = true;
            this.itineraryListBox.ItemHeight = 16;
            this.itineraryListBox.Location = new System.Drawing.Point(51, 399);
            this.itineraryListBox.Name = "itineraryListBox";
            this.itineraryListBox.Size = new System.Drawing.Size(650, 228);
            this.itineraryListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Itinerary";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(532, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 49);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 659);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.itineraryListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scheduleListBox);
            this.Controls.Add(this.label1);
            this.Name = "UserHomeForm";
            this.Text = "UserHomeForm";
            this.Load += new System.EventHandler(this.UserHomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox scheduleListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox itineraryListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
    }
}