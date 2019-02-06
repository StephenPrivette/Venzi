using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        // if password is valid returns true
        private bool passVal(string password)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // validating password length
            if (password.Length < 3 || password.Length > 10)
            {
                return false;
            }
            else
            {
                // for every char in password check to see if it meets each condition. if so that flag is true
                foreach (char ch in password)
                {
                    if (Char.IsUpper(ch))
                    {
                        upper = true;
                    }

                    if (Char.IsLower(ch))
                    {
                        lower = true;
                    }

                    if (!Char.IsLetterOrDigit(ch))
                    {
                        special = true;
                    }
                }

                // if all conditions are met then password is valid and method returns true
                return upper == true && lower == true && special == true;
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (passVal(passwordTextBox.Text))
            {
                if (userTextBox.Text.Length > 0 && userTextBox.Text.Length < 16)
                {
                    MessageBox.Show("Success");
                    // username and password meet criteria
                    // create entry in database through ProgramManager.instance
                }
                else
                {
                    MessageBox.Show("Your username does not meet criteria.");
                }
            }
            else
            {
                MessageBox.Show("Your password does not meet the criteria.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}