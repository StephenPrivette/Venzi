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
    // form for when the application starts up
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        // logs user into the application
        private void loginButton_Click(object sender, EventArgs e)
        {
            // loading main user method returns a string telling of it's errors or completion
            MessageBox.Show(ApplicationManager.i.loadMainUserFromDb(userTextBox.Text, passwordTextBox.Text));

            // if the main user has indeed been loaded
            if (ApplicationManager.i.mainUser != null)
            {
                this.Hide();

                HomeForm userHomeForm1 = new HomeForm();
                userHomeForm1.ShowDialog();

                MessageBox.Show("Signed out.");

                userTextBox.Text = "Username";
                userTextBox.ForeColor = Color.DarkGray;
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.DarkGray;
                passwordTextBox.PasswordChar = '\0';

                // since control returned after home form we must clear user object
                ApplicationManager.i.mainUser = null;
                this.Show();
            }
        }

        // when user clicks in text box
        private void userTextBox_Enter(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Username")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Username";
                userTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.White;
                passwordTextBox.PasswordChar = '*';
            }
        }

        // when user clicks out of text box
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.DarkGray;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        // when mouse hovers over label
        private void newUserLabel_MouseEnter(object sender, EventArgs e)
        {
            newUserLabel.Font = new Font(newUserLabel.Font.FontFamily, 9);
            newUserLabel.ForeColor = Color.FromArgb(120, 255, 255);
        }

        // when mouse leaves label
        private void newUserLabel_MouseLeave(object sender, EventArgs e)
        {
            newUserLabel.Font = new Font(newUserLabel.Font.FontFamily, 8);
            newUserLabel.ForeColor = Color.FromArgb(60, 150, 255);
        }

        // opens create user form
        private void newUserLabel_Click(object sender, EventArgs e)
        {
            // making sure there are first user types to select from
            if (ApplicationManager.i.getAllFromTable(new UserType()).Cast<UserType>().ToList().Count > 2)
            {
                this.Hide();
                CreateUserForm createUserForm1 = new CreateUserForm();
                createUserForm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The administrator must first create a user type in order to create a new user.");
            }
        }

        // when mouse hovers over label
        private void forgotPasswordLabel_MouseEnter(object sender, EventArgs e)
        {
            forgotPasswordLabel.Font = new Font(newUserLabel.Font.FontFamily, 9);
            forgotPasswordLabel.ForeColor = Color.FromArgb(120, 255, 255);
        }

        // when mouse leaves label
        private void forgotPasswordLabel_MouseLeave(object sender, EventArgs e)
        {
            forgotPasswordLabel.Font = new Font(newUserLabel.Font.FontFamily, 8);
            forgotPasswordLabel.ForeColor = Color.FromArgb(60, 150, 255);
        }

        // resets password
        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            // making sure user wants to reset
            if (MessageBox.Show("You will be given a temporary password. Are you sure you want to reset your password?",
                "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // making sure text box isn't blank
                if (!String.IsNullOrEmpty(userTextBox.Text))
                {
                    MessageBox.Show(ApplicationManager.i.resetPassword(userTextBox.Text));
                }
                else
                {
                    MessageBox.Show("A username must be entered in the Username box.");
                }
            }
        }
    }
}
