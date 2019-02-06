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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm1 = new LoginForm();
            loginForm1.ShowDialog();
            this.Show();
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
