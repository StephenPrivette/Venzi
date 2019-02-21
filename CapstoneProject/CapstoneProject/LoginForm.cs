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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(Apex.i.db.valUser(userTextBox.Text, passwordTextBox.Text))
            {
                Apex.i.loadUser(userTextBox.Text);
                this.Hide();
                UserHomeForm userHomeForm1 = new UserHomeForm();
                userHomeForm1.ShowDialog();
                this.Show();
            }  
            else
                MessageBox.Show("We do not have records for that user and/or password.");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
