namespace CapstoneProject
{
    partial class EventDetailsForm
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
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventNameLabel.Location = new System.Drawing.Point(-2, 16);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventNameLabel.Size = new System.Drawing.Size(130, 22);
            this.eventNameLabel.TabIndex = 84;
            this.eventNameLabel.Text = "Event Name:";
            this.eventNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(142, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 85;
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Name = "EventDetailsForm";
            this.Text = "EventDetailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}