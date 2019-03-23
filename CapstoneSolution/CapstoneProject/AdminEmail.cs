using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneClassLibrary;

namespace CapstoneProject
{
    public partial class AdminEmail : Form
    {
        public AdminEmail()
        {
            InitializeComponent();
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            string to = toTextBox.Text;
            string subject = subJectTextbox.Text;
            StringBuilder body = new StringBuilder();
            body.Append(bodyRichTextBox.Text);

            EmailLogic.SendEmail(to, subject, body.ToString());
        }
    }
}
