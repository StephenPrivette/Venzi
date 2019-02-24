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
            userTypeListBox.DataSource = Apex.i.db.loadUserTypes();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (Apex.i.valNewUser(userTextBox.Text, passwordTextBox.Text))
            {
                Apex.i.db.saveUser(userTextBox.Text, passwordTextBox.Text);

                if(userTypeListBox.SelectedItem.ToString() != "attendee")
                {
                    Apex.i.db.addUserRequest(userTextBox.Text, userTypeListBox.SelectedItem.ToString());
                }

                Apex.i.db.createItinerary(userTextBox.Text);

                MessageBox.Show("You have successfully created a user.");
            }
            else
                MessageBox.Show("Your username or password do not meet the criteria.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}