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
    public partial class EventDetailsForm : Form
    {
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        public void PopulateForm(String Name)
        {
            nameLabel.Text = Name;
        }
    }

}
