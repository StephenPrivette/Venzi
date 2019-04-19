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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // loading main user method returns a string telling of it's errors or completion
            MessageBox.Show(Apex.i.loadMainUserFromDb(userTextBox.Text, passwordTextBox.Text));

            // if the main user has indeed been loaded
            if (Apex.i.mainUser != null)
            {
                this.Hide();

                UserHomeForm attendeeHomeForm1 = new UserHomeForm();
                attendeeHomeForm1.ShowDialog();

                // since control returned after home form we must clear password and username and user object
                // MessageBox.Show("Signed out.");
                userTextBox.Clear();
                passwordTextBox.Clear();
                Apex.i.mainUser = null;
                this.Show();
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserForm createUserForm1 = new CreateUserForm();
            createUserForm1.ShowDialog();
            this.Show();
        }
    }
}
