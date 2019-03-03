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
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            // loading existing user itinerary from database into its user object
            Apex.i.loadItineraryFromDb();

            // on form load populate listviews
            populateListView(Apex.i.mainUser.getItinerary(), itineraryListView);
            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), scheduleListView);
        }

        // populates the listviews on this form with data
        private void populateListView(List<Event> events, ListView lv)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            foreach (Event i in events)
            {
                ListViewItem lvItem = new ListViewItem(i.startTime.ToString("HH:mm"));
                lvItem.SubItems.Add(i.startTime.ToString("t")
                    + " - " + (i.startTime + i.eventDuration).ToString("t"));
                lvItem.SubItems.Add(i.eventName);
                lvItem.SubItems.Add(i.eventType);
                lvItem.SubItems.Add(i.spaceName);
                lv.Items.Add(lvItem);
            }

            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // adding selected event in schedule list view to the itinerary in the mainuser object
            if (scheduleListView.SelectedItems.Count != 0)
            {
                foreach(Event eve in Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList())
                {
                    if(eve.eventName == scheduleListView.SelectedItems[0].SubItems[1].Text)
                    {
                        if (Apex.i.mainUser.addEventToItinerary(eve))
                        {
                            Apex.i.saveItineraryToDb();
                            Apex.i.loadItineraryFromDb();

                            populateListView(Apex.i.mainUser.getItinerary(), itineraryListView);
                        }
                        else
                        {
                            MessageBox.Show("That event has already been added.");
                        }
                    }
                }  
            }
            else
            {
                MessageBox.Show("You must select an event from the schedule.");
            }
            
        }

        private void deleteItineraryItem_Click(object sender, EventArgs e)
        {
            // deleting selected event in itinerary list view
            bool delete = false;
            Event eveCopy = new Event();

            // making sure something was selected
            if (itineraryListView.SelectedItems.Count != 0)
            {
                foreach (Event eve in Apex.i.mainUser.getItinerary())
                {
                    if (eve.eventName == itineraryListView.SelectedItems[0].SubItems[1].Text)
                    {
                        // have to use these because removing event here would mutate the for loop
                        eveCopy = eve;
                        delete = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select an event from the itinerary.");
            }

            if(delete)
            {
                if (Apex.i.mainUser.deletEventFromItinerary(eveCopy))
                {
                    Apex.i.saveItineraryToDb();
                    Apex.i.loadItineraryFromDb();

                    populateListView(Apex.i.mainUser.getItinerary(), itineraryListView);
                }
                else
                {
                    MessageBox.Show("That event has already been deleted.");
                }
            }
        }

        // hiding and showing buttons based on which list view is clicked on
        private void scheduleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            addButton.Enabled = true;
        }

        private void itineraryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            addButton.Enabled = false;
        }

        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            if(changeUsernameTextBox.Text != null)
            {
                MessageBox.Show(Apex.i.changeMainUserName(changeUsernameTextBox.Text));
            }
            else
            {
                MessageBox.Show("You must enter a new username in the textbox.");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (changePasswordTextBox.Text != null)
            {
                MessageBox.Show(Apex.i.changeMainUserPassword(changePasswordTextBox.Text));
            }
            else
            {
                MessageBox.Show("You must enter a new password in the textbox.");
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
