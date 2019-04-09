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

            if (Apex.i.mainUser.userTypeName == "Administrator")
            {
                tabControl1.TabPages.Remove(scheduleTabPage);
            }
            else if (Apex.i.mainUser.userTypeName == "Attendee")
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
            }
            else if (Apex.i.mainUser.userTypeName == "Performer")
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
            }
            else if (Apex.i.mainUser.userTypeName == "Staff")
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
            }
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            // loading existing user itinerary from database into its user object
            Apex.i.loadItineraryFromDb();

            // on form load populate listviews
            populateEventListView(Apex.i.mainUser.getItinerary().OrderBy(x => x.startTime).ToList(), itineraryListView);
            populateEventListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList().OrderBy(x => x.startTime).ToList(), scheduleListView);
            populateEventListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList().OrderBy(x => x.startTime).ToList(), eveManEventsListView);

            loadEventTypes();
            loadLocations();
        }

        private void loadEventTypes()
        {
            eventTypeListBox.SelectedItems.Clear();
            eventTypeListBox.Items.Clear();

            foreach (EventType type in Apex.i.getAllFromTable(new EventType()).Cast<EventType>().ToList())
            {
                eventTypeListBox.Items.Add(type.eventTypeName);
            }
        }

        private void loadLocations()
        {
            locationListBox.SelectedItems.Clear();
            locationListBox.Items.Clear();

            foreach (Location loc in Apex.i.getAllFromTable(new Location()).Cast<Location>().ToList())
            {
                locationListBox.Items.Add(loc.locationName);
            }
        }

        // populates the listviews on this form with data
        private void populateEventListView(List<Event> events, ListView lv)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            foreach (Event i in events)
            {
                ListViewItem lvItem = new ListViewItem(i.startTime.ToString("MM/dd h:mm tt")
                    + " - " + (i.startTime + i.eventDuration).ToString("t"));
                lvItem.SubItems.Add(i.eventName);
                lvItem.SubItems.Add(i.eventTypeName);
                lvItem.SubItems.Add(i.locationName);
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

                            populateEventListView(Apex.i.mainUser.getItinerary().OrderBy(x => x.startTime).ToList(), itineraryListView);
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

                    populateEventListView(Apex.i.mainUser.getItinerary().OrderBy(x => x.startTime).ToList(), itineraryListView);
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

        // changes user name when clicked
        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            // making sure there is text in the textbox
            if(changeUsernameTextBox.Text != null)
            {
                MessageBox.Show(Apex.i.changeMainUserName(changeUsernameTextBox.Text));
            }
            else
            {
                MessageBox.Show("You must enter a new username in the textbox.");
            }
        }

        // changes user password when clicked
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            // checking to see that there is indeed text in the text box
            if (!String.IsNullOrEmpty(changePasswordTextBox.Text))
            {
                MessageBox.Show(Apex.i.changeMainUserPassword(changePasswordTextBox.Text));
            }
            else
            {

                MessageBox.Show("You must enter a new password in the textbox.");
            }
        }

        // exits out to start form
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // loads event editor page when clicked
        private void eventEditorButton_Click(object sender, EventArgs e)
        {
            EventEditorForm eventEditorForm1 = new EventEditorForm();
            eventEditorForm1.ShowDialog();
        }

        // deletes event type 
        private void deleteTypeButton_Click(object sender, EventArgs e)
        {
            if (eventTypeListBox.SelectedIndex >= 0)
            {
                // checking with user to ensure they really want to delete the event type
                if(MessageBox.Show("Are you sure you want to delete the " + eventTypeListBox.SelectedItem.ToString() +
                    " Event Type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string message = Apex.i.deleteEventTypeFromDb(new EventType(), eventTypeListBox.SelectedItem.ToString());

                    // if the message is good don't show it
                    if(message != new EventType().GetType().Name + " has been deleted.")
                    {
                        MessageBox.Show(message);
                    }

                    loadEventTypes();
                }
            }
            else
            {
                MessageBox.Show("You must select an event type from the list.");
            }
        }

        // adds event type to database
        private void addTypeButton_Click(object sender, EventArgs e)
        {
            if(eventTypeTextBox.Text.Length > 0)
            {
                EventType et = new EventType();
                et.eventTypeName = eventTypeTextBox.Text;

                string message = Apex.i.addEventTypeToDb(et, eventTypeTextBox.Text);

                // if the message is good don't show it
                if (message != et.GetType().Name + " has been added.")
                {
                    MessageBox.Show(message);
                }

                loadEventTypes();
            }
            else
            {
                MessageBox.Show("You must type a name in the text box.");
            }
        }

        // deletes location
        private void deleteLocationButton_Click(object sender, EventArgs e)
        {
            if (locationListBox.SelectedIndex >= 0)
            {
                // ensuring user wants deletion
                if (MessageBox.Show("Are you sure you want to delete the " + locationListBox.SelectedItem.ToString() +
                    " Location?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string message = Apex.i.deleteLocationFromDb(new Location(), locationListBox.SelectedItem.ToString());

                    // if message is good don't show it
                    if (message != new Location().GetType().Name + " has been deleted.")
                    {
                        MessageBox.Show(message);
                    }

                    loadLocations();
                }
            }
            else
            {
                MessageBox.Show("You must select a location from the list.");
            }
        }

        // adds location 
        private void addLocationButton_Click(object sender, EventArgs e)
        {
            // making sure text box is not empty
            if (locationTextBox.Text.Length > 0)
            {
                Location loc = new Location();
                loc.locationName = locationTextBox.Text;

                string message = Apex.i.addLocationToDb(loc, locationTextBox.Text);

                // if message is good don't show it
                if (message != loc.GetType().Name + " has been added.")
                {
                    MessageBox.Show(message);
                }

                loadLocations();
            }
            else
            {
                MessageBox.Show("You must type a name in the text box.");
            }
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            StringBuilder body = new StringBuilder();
            body.Append(bodyRichTextBox.Text);

            Apex.i.sendEmail(toTextBox.Text, subjectTextbox.Text, body.ToString());
        }
    }
}
