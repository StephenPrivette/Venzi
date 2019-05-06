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
    // form for displaying the description of the event
    public partial class EventDetailsForm : Form
    {
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        public void PopulateForm(string name, string description)
        {
            // Displays various attributes of selected event.
            eventNameLabel.Text = name;
            descriptionLabel.Text = description;
        }
    }
}
