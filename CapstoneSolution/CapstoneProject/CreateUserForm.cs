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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();

            foreach (UserType type in Apex.i.getAllFromTable(new UserType()).Cast<UserType>().ToList())
            {
                userTypeListBox.Items.Add(type.userType);
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            // making sure something was selected
            if (userTypeListBox.SelectedIndex >= 0)
            {
                // method returns string showing errors or completion
                string mes = Apex.i.createNewUser(userTextBox.Text, passwordTextBox.Text, userTypeListBox.SelectedItem.ToString());

                // did this to ensure form would close if successful
                if (mes == "The user has been created successfully.")
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
                MessageBox.Show("You must select a user type.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}