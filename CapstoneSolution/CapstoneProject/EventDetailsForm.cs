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
        // Form for displaying details about whatever event the user selects.
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        public void PopulateForm(string name, string startTime, string duration, string location, string type, string setup, string breakdown, 
                                 string description)
        {
            // Displays various attributes of selected event.
            nameLabel.Text = name;
            startLabel.Text = startTime;
            durationLabel.Text = duration;
            locationLabel.Text = location;
            typeLabel.Text = type;
            setupLabel.Text = setup;
            descriptionLabel.Text = description;
        }
    }

}
