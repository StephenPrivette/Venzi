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
    // form for creating a new user
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();

            // populating list box
            foreach (UserType type in ApplicationManager.i.getAllFromTable(new UserType()).Cast<UserType>().ToList())
            {
                if(type.userTypeName != "Administrator" && type.userTypeName != "Basic")
                {
                    userTypeListBox.Items.Add(type.userTypeName);
                }
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            // making sure something was selected
            if (userTypeListBox.SelectedIndex >= 0)
            {
                if (userTextBox.ForeColor == Color.White && firstTextBox.ForeColor == Color.White &&
                    lastTextBox.ForeColor == Color.White && passwordTextBox.ForeColor == Color.White &&
                    emailTextBox.ForeColor == Color.White)
                {
                    // method returns string showing errors or completion
                    string mes = ApplicationManager.i.createNewUser(userTextBox.Text, firstTextBox.Text, lastTextBox.Text, passwordTextBox.Text, userTypeListBox.SelectedItem.ToString(), emailTextBox.Text);

                    // did this to ensure form would close if successful
                    if (mes == "The user has been created successfully." ||
                        mes == "The user has been created successfully. The user type selected requires " +
                        "special permission from the administrator. A request has been made. In the meantime events " +
                        "can be viewed under our basic user type. Please check your email for the result of the request.")
                    {
                        MessageBox.Show(mes);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mes);
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled in.");
                }
            }
            else
            {
                MessageBox.Show("You must select a user type.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void firstTextBox_Enter(object sender, EventArgs e)
        {
            if (firstTextBox.Text == "First Name")
            {
                firstTextBox.Text = "";
                firstTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void firstTextBox_Leave(object sender, EventArgs e)
        {
            if (firstTextBox.Text == "")
            {
                firstTextBox.Text = "First Name";
                firstTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void lastTextBox_Enter(object sender, EventArgs e)
        {
            if (lastTextBox.Text == "Last Name")
            {
                lastTextBox.Text = "";
                lastTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void lastTextBox_Leave(object sender, EventArgs e)
        {
            if (lastTextBox.Text == "")
            {
                lastTextBox.Text = "Last Name";
                lastTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email Address")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email Address";
                emailTextBox.ForeColor = Color.DarkGray;
            }
        }
    }
}