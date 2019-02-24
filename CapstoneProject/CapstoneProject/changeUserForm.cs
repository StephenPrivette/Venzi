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
    public partial class ChangeUserForm : Form
    {
        public ChangeUserForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            Apex.i.db.updateUserInfo(oldUsernameTextBox.Text, oldPasswordTextbox.Text, newPasswordTextbox.Text);
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
