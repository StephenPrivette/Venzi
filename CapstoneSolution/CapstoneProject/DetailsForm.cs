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
    public partial class DetailsForm : Form
    {
        // NOTE - Form UI not final, just trying to get the logic figured out - ATW
        public DetailsForm()
        {
            InitializeComponent();
        }

        public void populateForm(string eventName, string eventDuration, string eventLocation, string eventType, string eventDesc)
        {
            // Fills in each label with the appropriate information.
            eventNameLabel.Text = eventName;
            eventDurationLabel.Text = eventDuration;
            eventLocationLabel.Text = eventLocation;
            eventTypeLabel.Text = eventType;
            eventDescriptionLabel.Text = eventDesc;
        }
    }
}
