namespace CapstoneProject
{
    partial class AdminEmail
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
            this.label2 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.Label();
            this.subJectTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send e-mail TEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TO:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(292, 135);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(245, 20);
            this.toTextBox.TabIndex = 2;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(243, 171);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(43, 13);
            this.Subject.TabIndex = 3;
            this.Subject.Text = "Subject";
            // 
            // subJectTextbox
            // 
            this.subJectTextbox.Location = new System.Drawing.Point(292, 171);
            this.subJectTextbox.Name = "subJectTextbox";
            this.subJectTextbox.Size = new System.Drawing.Size(245, 20);
            this.subJectTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body";
            // 
            // bodyRichTextBox
            // 
            this.bodyRichTextBox.Location = new System.Drawing.Point(216, 229);
            this.bodyRichTextBox.Name = "bodyRichTextBox";
            this.bodyRichTextBox.Size = new System.Drawing.Size(352, 176);
            this.bodyRichTextBox.TabIndex = 6;
            this.bodyRichTextBox.Text = "";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(366, 425);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(75, 23);
            this.sendEmailButton.TabIndex = 7;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(626, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "This should be a pulldown query that lets us see all of our user email properties" +
    ", right now just hardcoding strings to test functionality ";
            // 
            // AdminEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.bodyRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subJectTextbox);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminEmail";
            this.Text = "Send Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.TextBox subJectTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox bodyRichTextBox;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Label label4;
    }
}