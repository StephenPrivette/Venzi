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

            UserType currentUserType = (UserType)Apex.i.getObjectFromDbByName(new UserType(), Apex.i.mainUser.userTypeName);

            if (currentUserType.userPermissionsLevel == 0)
            {
                tabControl1.TabPages.Remove(scheduleTabPage);
            }
            else if (currentUserType.userPermissionsLevel == 1)
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
                tabControl1.TabPages.Remove(emailTabPage);

                label2.Text = "Your Work Schedule";
                addButton.Visible = false;
                deleteButton.Visible = false;
            }
            else
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
                tabControl1.TabPages.Remove(emailTabPage);
            }
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            // loading existing user itinerary from database into its user object
            Apex.i.loadItineraryFromDb();

            // on form load populate listviews
            eveManComboBox.SelectedIndex = 0;
            scheduleComboBox.SelectedIndex = 0;
            itineraryComboBox.SelectedIndex = 0;
            userRequestsComboBox.SelectedIndex = 0;

            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eveManEventsListView, eveManComboBox);
            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), scheduleListView, scheduleComboBox);
            populateListView(Apex.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);

            populateUserRequestListView(Apex.i.getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList(),
                userRequestsListView);

            loadEventTypes();
            loadLocations();
            loadUserTypes();
        }

        private void loadEventTypes()
        {
            eventTypeListBox.SelectedItems.Clear();
            eventTypeListBox.Items.Clear();
            eventTypeTextBox.Clear();

            foreach (EventType type in Apex.i.getAllFromTable(new EventType()).Cast<EventType>().ToList())
            {
                eventTypeListBox.Items.Add(type.eventTypeName);
            }
        }

        private void loadLocations()
        {
            locationListBox.SelectedItems.Clear();
            locationListBox.Items.Clear();
            locationTextBox.Clear();

            foreach (Location loc in Apex.i.getAllFromTable(new Location()).Cast<Location>().ToList())
            {
                locationListBox.Items.Add(loc.locationName);
            }
        }

        private void loadUserTypes()
        {
            userTypeListBox.SelectedItems.Clear();
            userTypeListBox.Items.Clear();
            userTypeTextBox.Clear();

            foreach (UserType type in Apex.i.getAllFromTable(new UserType()).Cast<UserType>().ToList())
            {
                userTypeListBox.Items.Add(type.userTypeName);
            }
        }

        // populates the listviews on this form with data
        private void populateListView(List<Event> events, ListView lv, ComboBox cb)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            if (cb.SelectedIndex == 0)
            {
                events = events.OrderBy(x => x.startTime).ToList();
            }
            else if (cb.SelectedIndex == 1)
            {
                events = events.OrderBy(x => x.eventTypeName).ToList();
            }
            else if (cb.SelectedIndex == 2)
            {
                events = events.OrderBy(x => x.locationName).ToList();
            }
            else
            {
                events = events.OrderBy(x => x.startTime).ToList();
            }

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

        // populates the listviews on this form with data
        private void populateUserRequestListView(List<UserTypeRequest> requests, ListView lv)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            requests = requests.OrderBy(x => x.userTypeName).ToList();

            foreach (UserTypeRequest i in requests)
            {
                User userWhoRequested = (User)Apex.i.getObjectFromDbById(new User(), i.userID);

                ListViewItem lvItem = new ListViewItem(i.userTypeName.ToString());
                lvItem.SubItems.Add(userWhoRequested.userName);
                lvItem.SubItems.Add(userWhoRequested.userFirstName);
                lvItem.SubItems.Add(userWhoRequested.userLastName);
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

                            populateListView(Apex.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);
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

                    populateListView(Apex.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);
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

            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eveManEventsListView, eveManComboBox);
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
            if (Apex.i.sendEmail(toTextBox.Text, subjectTextbox.Text, body.ToString()) == 1)
            {
                MessageBox.Show("Email Sent");
                toTextBox.Text = "";
                subjectTextbox.Text = "";
                bodyRichTextBox.Text = "";
            }
            

        }

        private void eveManComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eveManEventsListView, eveManComboBox);
        }

        private void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), scheduleListView, scheduleComboBox);
        }

        private void itineraryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(Apex.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);
        }
        
        private void deleteUserTypeButton_Click(object sender, EventArgs e)
        {
            if (userTypeListBox.SelectedIndex >= 0)
            {
                // checking with user to ensure they really want to delete the event type
                if (MessageBox.Show("Are you sure you want to delete the " + userTypeListBox.SelectedItem.ToString() +
                    " User Type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string message = Apex.i.deleteUserTypeFromDb(new UserType(), userTypeListBox.SelectedItem.ToString());

                    // if the message is good don't show it
                    if (message != new UserType().GetType().Name + " has been deleted.")
                    {
                        MessageBox.Show(message);
                    }

                    loadUserTypes();
                }
            }
            else
            {
                MessageBox.Show("You must select a user type from the list.");
            }
        }

        private void addUserTypeButton_Click(object sender, EventArgs e)
        {
            // making sure text box is not empty
            if (userTypeTextBox.Text.Length > 0)
            {
                if(permissionsComboBox.SelectedIndex != -1)
                {
                    UserType ut = new UserType();
                    ut.userTypeName = userTypeTextBox.Text;
                    ut.userPermissionsLevel = permissionsComboBox.SelectedIndex;

                    string message = Apex.i.addUserTypeToDb(ut, userTypeTextBox.Text);

                    // if message is good don't show it
                    if (message != ut.GetType().Name + " has been added.")
                    {
                        MessageBox.Show(message);
                    }

                    loadUserTypes();
                }
                else
                {
                    MessageBox.Show("You must select a permissions level");
                }
            }
            else
            {
                MessageBox.Show("You must type a name in the text box.");
            }
        }

        private void userTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userTypeListBox.SelectedIndex >= 0)
            {
                UserType ut = (UserType)Apex.i.getObjectFromDbByName(new UserType(), userTypeListBox.SelectedItem.ToString());
                permissionsComboBox.SelectedIndex = ut.userPermissionsLevel;
                if(ut.userPermissionsLevel == 0)
                {
                    permissionsLabel.Text = "Full access. (the permissions you are currently logged in with)" +
                        " The ability to create/delete events, locations, types, etc. Recommended for administrators only.";
                }
                else if (ut.userPermissionsLevel == 1)
                {
                    permissionsLabel.Text = "Limited access. Changes the itinerary to a work schedule." +
                        " The ability to view but not create or delete. Recommended for staff only.";
                }
                else
                {
                    permissionsLabel.Text = "Very limited access. Adds the ability to add or delete events from a personal itinerary." +
                        " The ability to view but not create or delete. Recommended for attendees/non-employees.";
                }
            }
        }

        private void changePermissionsButton_Click(object sender, EventArgs e)
        {
            if (userTypeListBox.SelectedIndex >= 0)
            {
                if (permissionsComboBox.SelectedIndex != -1)
                {
                    // checking with user to ensure they really want to delete the event type
                    if (MessageBox.Show("Are you sure you want to update the permissions for " + userTypeListBox.SelectedItem.ToString() +
                        " User Type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UserType ut = new UserType();
                        ut.userTypeName = userTypeListBox.SelectedItem.ToString();
                        ut.userPermissionsLevel = permissionsComboBox.SelectedIndex;

                        string message = Apex.i.updateUserTypePermissions(ut);

                        // if message is good don't show it
                        if (message != ut.GetType().Name + " has been added.")
                        {
                            MessageBox.Show(message);
                        }

                        loadUserTypes();
                    }
                }
                else
                {
                    MessageBox.Show("You must select a permissions level");
                }
            }
            else
            {
                MessageBox.Show("A type must be selected in the list box.");
            }
        }

        private void permissionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (permissionsComboBox.SelectedIndex == 0)
            {
                permissionsLabel.Text = "Full access. (the permissions you are currently logged in with)" +
                    " The ability to create/delete events, locations, types, etc. Recommended for administrators only.";
            }
            else if (permissionsComboBox.SelectedIndex == 1)
            {
                permissionsLabel.Text = "Limited access. Changes the itinerary to a work schedule." +
                    " The ability to view but not create or delete. Recommended for staff only.";
            }
            else
            {
                permissionsLabel.Text = "Very limited access. Adds the ability to add or delete events from a personal itinerary." +
                    " The ability to view but not create or delete. Recommended for attendees/non-employees.";
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAssignmentForm userAssignmentForm1 = new UserAssignmentForm();
            userAssignmentForm1.ShowDialog();
            this.Show();
        }

        private void grantButton_Click(object sender, EventArgs e)
        {
            if (userRequestsListView.SelectedItems.Count != 0)
            {
                MessageBox.Show(Apex.i.grantUserTypeRequest(userRequestsListView.SelectedItems[0].SubItems[1].Text));

                populateUserRequestListView(Apex.i.getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList(),
                userRequestsListView);
            }
            else
            {
                MessageBox.Show("A request from the list must be selected.");
            }
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            if (userRequestsListView.SelectedItems.Count != 0)
            {
                MessageBox.Show(Apex.i.denyUserTypeRequest(userRequestsListView.SelectedItems[0].SubItems[1].Text));

                populateUserRequestListView(Apex.i.getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList(),
                userRequestsListView);
            }
            else
            {
                MessageBox.Show("A request from the list must be selected.");
            }
        }

        
    }
}