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
    // this form is the main form of the program. it is what the user sees once they log in
    public partial class HomeForm : Form
    {
        // captured email addresses from loadUserEmailAddresses. used because that method concantenates things with the email address
        // so we needed a way to have a list of just email addresses with the same index as the combo box 
        List<string> emailAddresses;

        public HomeForm()
        {
            InitializeComponent();

            // needed for double-click event to work
            scheduleListView.MouseDoubleClick += new MouseEventHandler(scheduleListView_MouseDoubleClick);

            // getting permission level of user
            UserType currentUserType = (UserType)ApplicationManager.i.getObjectFromDbByName(new UserType(), ApplicationManager.i.mainUser.userTypeName);

            // based on permission level of user's type different aspects of the form are displayed
            if (currentUserType.userPermissionsLevel == 0)
            {
                tabControl1.TabPages.Remove(scheduleTabPage);
            }
            else if (currentUserType.userPermissionsLevel == 1)
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
                tabControl1.TabPages.Remove(emailTabPage);

                itineraryLabel.Text = "Your Work Schedule";
                addButton.Visible = false;
                deleteButton.Visible = false;
                conventionTitleTextBox.Visible = false;
                conventionSubtitleTextBox.Visible = false;
                conventionDescriptionTextBox.Visible = false;
                conventionDisplayButton.Visible = false;
                conventionSaveButton.Visible = false;
                itineraryListView.Columns[2].Width = 100;
                itineraryListView.Columns[3].Width = 100;
            }
            else if (currentUserType.userPermissionsLevel == 2)
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
                tabControl1.TabPages.Remove(emailTabPage);

                conventionTitleTextBox.Visible = false;
                conventionSubtitleTextBox.Visible = false;
                conventionDescriptionTextBox.Visible = false;
                conventionDisplayButton.Visible = false;
                conventionSaveButton.Visible = false;
                itineraryListView.Columns[4].Width = 0;
                itineraryListView.Columns[5].Width = 0;
            }
            else
            {
                tabControl1.TabPages.Remove(eventsTabPage);
                tabControl1.TabPages.Remove(userTabPage);
                tabControl1.TabPages.Remove(emailTabPage);

                itineraryListView.Visible = false;
                itineraryComboBox.Visible = false;
                addButton.Visible = false;
                deleteButton.Visible = false;
                itineraryLabel.Visible = false;
                itineraryOrderLabel.Visible = false;
                scheduleListView.Height += 100;
                conventionTitleTextBox.Visible = false;
                conventionSubtitleTextBox.Visible = false;
                conventionDescriptionTextBox.Visible = false;
                conventionDisplayButton.Visible = false;
                conventionSaveButton.Visible = false;
                itineraryListView.Columns[4].Width = 0;
                itineraryListView.Columns[5].Width = 0;
            }
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            emailAddresses = new List<string>();

            // loading existing user itinerary from database into its user object
            ApplicationManager.i.loadItineraryFromDb();

            // on form load populate listviews
            eveManComboBox.SelectedIndex = 0;
            scheduleComboBox.SelectedIndex = 0;
            itineraryComboBox.SelectedIndex = 0;
            userRequestsComboBox.SelectedIndex = 0;

            populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eveManEventsListView, eveManComboBox);
            populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), scheduleListView, scheduleComboBox);
            populateListView(ApplicationManager.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);

            populateUserRequestListView(ApplicationManager.i.getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList(),
                userRequestsListView);

            loadEventTypes();
            loadLocations();
            loadUserTypes();
            loadUserEmailAddresses();
            loadGeneralInfo();
        }

        // loads event types into list box
        private void loadEventTypes()
        {
            eventTypeListBox.SelectedItems.Clear();
            eventTypeListBox.Items.Clear();
            eventTypeTextBox.Text = "New Event Type";
            eventTypeTextBox.ForeColor = Color.DarkGray;

            foreach (EventType type in ApplicationManager.i.getAllFromTable(new EventType()).Cast<EventType>().ToList())
            {
                eventTypeListBox.Items.Add(type.eventTypeName);
            }
        }

        // loads locations into list box
        private void loadLocations()
        {
            locationListBox.SelectedItems.Clear();
            locationListBox.Items.Clear();
            locationTextBox.Text = "New Location";
            locationTextBox.ForeColor = Color.DarkGray;

            foreach (Location loc in ApplicationManager.i.getAllFromTable(new Location()).Cast<Location>().ToList())
            {
                locationListBox.Items.Add(loc.locationName);
            }
        }

        // loads user types into list box
        private void loadUserTypes()
        {
            userTypeListBox.SelectedItems.Clear();
            userTypeListBox.Items.Clear();
            userTypeTextBox.Text = "New User Type";
            userTypeTextBox.ForeColor = Color.DarkGray;

            foreach (UserType type in ApplicationManager.i.getAllFromTable(new UserType()).Cast<UserType>().ToList())
            {
                userTypeListBox.Items.Add(type.userTypeName);
            }
        }

        // populates the listviews on this form with data
        private void populateListView(List<Event> events, ListView lv, ComboBox cb)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            // orders list differently depending on combo box selection
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

            UserType ut = (UserType)ApplicationManager.i.getObjectFromDbByName(new UserType(),
                    ApplicationManager.i.mainUser.userTypeName);

            foreach (Event i in events)
            {
                ListViewItem lvItem = new ListViewItem(i.startTime.ToString("MM/dd h:mm tt")
                    + " - " + (i.startTime + i.eventDuration).ToString("t"));
                lvItem.SubItems.Add(i.eventName);
                lvItem.SubItems.Add(i.eventTypeName);
                lvItem.SubItems.Add(i.locationName);

                if (ut.userPermissionsLevel == 1)
                {
                    lvItem.SubItems.Add((i.startTime - i.setupDuration).ToString("t"));
                    lvItem.SubItems.Add((i.startTime + i.eventDuration + i.breakdownDuration).ToString("t"));
                }

                EventType et = (EventType)ApplicationManager.i.getObjectFromDbByName(new EventType(), i.eventTypeName);
                lvItem.UseItemStyleForSubItems = false;
                lvItem.SubItems[2].BackColor = Color.FromArgb(et.eventTypeColor);

                lv.Items.Add(lvItem);
            }
        }

        // loads all user email addresses into combo box
        private void loadUserEmailAddresses()
        {
            emailAddresses.Clear();
            toComboBox.Items.Clear();

            foreach (User u in ApplicationManager.i.getAllFromTable(new User()).Cast<User>().ToList())
            {
                toComboBox.Items.Add(u.userName + ", " + u.userFirstName + " " + u.userLastName + ", " + u.userEmail);
                emailAddresses.Add(u.userEmail);
            }
        }

        // loads the general information about the convention into the appropriate fields
        private void loadGeneralInfo()
        {
            ConventionTitle conventionTitle1 = (ConventionTitle)ApplicationManager.i.getObjectFromDbByName(new ConventionTitle(),
                "convention");

            conventionTitleLabel.Text = conventionTitle1.conventionTitleTitle;
            conventionSubtitleLabel.Text = conventionTitle1.conventionTitleSubtitle;
            conventionDisplayDescTextBox.Text = conventionTitle1.conventionTitleDescription;
        }

        // populates the listviews on this form with data
        private void populateUserRequestListView(List<UserTypeRequest> requests, ListView lv)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            requests = requests.OrderBy(x => x.userTypeName).ToList();

            // getting each user who has a user request
            foreach (UserTypeRequest i in requests)
            {
                User userWhoRequested = (User)ApplicationManager.i.getObjectFromDbById(new User(), i.userID);

                ListViewItem lvItem = new ListViewItem(i.userTypeName.ToString());
                lvItem.SubItems.Add(userWhoRequested.userName);
                lvItem.SubItems.Add(userWhoRequested.userFirstName);
                lvItem.SubItems.Add(userWhoRequested.userLastName);
                lv.Items.Add(lvItem);
            }
        }

        // adds event to user's itinerary
        private void addButton_Click(object sender, EventArgs e)
        {
            if (scheduleListView.SelectedItems.Count != 0)
            {
                foreach(Event eve in ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList())
                {
                    // if event in database matches event selected in list view
                    if(eve.eventName == scheduleListView.SelectedItems[0].SubItems[1].Text)
                    {
                        if (ApplicationManager.i.mainUser.addEventToItinerary(eve))
                        {
                            ApplicationManager.i.saveItineraryToDb();
                            ApplicationManager.i.loadItineraryFromDb();

                            populateListView(ApplicationManager.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);
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
                MessageBox.Show("An event must be selected from the schedule.");
            }
            
        }

        // deletes selected event from user's itinerary
        private void deleteItineraryItem_Click(object sender, EventArgs e)
        {
            bool delete = false;
            Event eveCopy = new Event();

            // making sure something was selected
            if (itineraryListView.SelectedItems.Count != 0)
            {
                foreach (Event eve in ApplicationManager.i.mainUser.getItinerary())
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
                MessageBox.Show("An event must be selected from the itinerary.");
            }

            if(delete)
            {
                if (ApplicationManager.i.mainUser.deletEventFromItinerary(eveCopy))
                {
                    ApplicationManager.i.saveItineraryToDb();
                    ApplicationManager.i.loadItineraryFromDb();

                    populateListView(ApplicationManager.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);
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

        // hiding and showing buttons based on which list view is clicked on
        private void itineraryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            addButton.Enabled = false;
        }

        // changes user name when clicked
        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            // making sure there is text in the textbox
            if (changeUsernameTextBox.ForeColor == Color.White)
            {
                // checking with user to ensure they really want to change their username
                if (MessageBox.Show("Are you sure you want to change your Username to " + changeUsernameTextBox.Text +
                    "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(ApplicationManager.i.changeMainUserName(changeUsernameTextBox.Text));
                    changeUsernameTextBox.Text = "New Username";
                    changeUsernameTextBox.ForeColor = Color.DarkGray;
                }
            }
            else
            {
                MessageBox.Show("A new username must be entered into the textbox.");
            }
        }

        // changes user password when clicked
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            // checking to see that there is indeed text in the text box
            if (changePasswordTextBox.ForeColor == Color.White)
            {
                // checking with user to ensure they really want to change their password
                if (MessageBox.Show("Are you sure you want to change your Password to " + changePasswordTextBox.Text +
                    "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(ApplicationManager.i.changeMainUserPassword(changePasswordTextBox.Text));
                    changePasswordTextBox.Text = "New Password";
                    changePasswordTextBox.ForeColor = Color.DarkGray;
                }
            }
            else
            {

                MessageBox.Show("A new password must be entered into the textbox.");
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
            // making sure event types exist before allowing event creation
            if (ApplicationManager.i.getAllFromTable(new EventType()).Cast<EventType>().ToList().Count > 0)
            {
                // making sure locations exist before allowing event creation
                if (ApplicationManager.i.getAllFromTable(new Location()).Cast<Location>().ToList().Count > 0)
                {
                    EventEditorForm eventEditorForm1 = new EventEditorForm();
                    this.Hide();
                    eventEditorForm1.ShowDialog();
                    this.Show();
                    populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(),
                        eveManEventsListView, eveManComboBox);
                }
                else
                {
                    MessageBox.Show("Locations must be created first before creating events.");
                }
            }
            else
            {
                MessageBox.Show("Event types must be created first before creating events.");
            }
        }

        // adds event type to database
        private void addTypeButton_Click(object sender, EventArgs e)
        {
            if(eventTypeTextBox.ForeColor == Color.White)
            {
                MessageBox.Show(ApplicationManager.i.addEventTypeToDb(eventTypeTextBox.Text, colorLabel.BackColor.ToArgb()));

                loadEventTypes();
            }
            else
            {
                MessageBox.Show("An event type name must be entered into the text box.");
            }
        }

        // deletes event type 
        private void deleteTypeButton_Click(object sender, EventArgs e)
        {
            if (eventTypeListBox.SelectedIndex >= 0)
            {
                // checking with user to ensure they really want to delete the event type
                if (MessageBox.Show("Are you sure you want to delete the " + eventTypeListBox.SelectedItem.ToString() +
                    " event type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(ApplicationManager.i.deleteEventTypeFromDb(eventTypeListBox.SelectedItem.ToString()));

                    loadEventTypes();
                }
            }
            else
            {
                MessageBox.Show("An event type must be selected from the list.");
            }
        }

        // adds location 
        private void addLocationButton_Click(object sender, EventArgs e)
        {
            // making sure text box is not empty
            if (locationTextBox.ForeColor == Color.White)
            {
                MessageBox.Show(ApplicationManager.i.addLocationToDb(locationTextBox.Text));

                loadLocations();
            }
            else
            {
                MessageBox.Show("A location name must be entered into the text box.");
            }
        }

        // deletes location
        private void deleteLocationButton_Click(object sender, EventArgs e)
        {
            if (locationListBox.SelectedIndex >= 0)
            {
                // ensuring user wants deletion
                if (MessageBox.Show("Are you sure you want to delete the " + locationListBox.SelectedItem.ToString() +
                    " location?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(ApplicationManager.i.deleteLocationFromDb(locationListBox.SelectedItem.ToString()));

                    loadLocations();
                }
            }
            else
            {
                MessageBox.Show("A location must be selected from the list.");
            }
        }

        // adds user type to database
        private void addUserTypeButton_Click(object sender, EventArgs e)
        {
            // making sure text box is not empty
            if (userTypeTextBox.ForeColor == Color.White)
            {
                if(permissionsComboBox.SelectedIndex != -1)
                {
                    MessageBox.Show(ApplicationManager.i.addUserTypeToDb(userTypeTextBox.Text, permissionsComboBox.SelectedIndex));

                    loadUserTypes();
                }
                else
                {
                    MessageBox.Show("A permissions level must be selected from the box");
                }
            }
            else
            {
                MessageBox.Show("A user type name must be entered into the text box.");
            }
        }

        // deletes user type
        private void deleteUserTypeButton_Click(object sender, EventArgs e)
        {
            if (userTypeListBox.SelectedIndex >= 0)
            {
                if (userTypeListBox.SelectedItem.ToString() != "Administrator" && userTypeListBox.SelectedItem.ToString() != "Basic")
                {
                    // checking with user to ensure they really want to delete the user type
                    if (MessageBox.Show("Are you sure you want to delete the " + userTypeListBox.SelectedItem.ToString() +
                        " user type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show(ApplicationManager.i.deleteUserTypeFromDb(userTypeListBox.SelectedItem.ToString()));

                        loadUserTypes();
                    }
                }
                else
                {
                    MessageBox.Show("The user types Administrator and Basic cannot be deleted.");
                }
            }
            else
            {
                MessageBox.Show("A user type must be selected from the list.");
            }
        }

        // changes order of list view
        private void eveManComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eveManEventsListView, eveManComboBox);
        }

        // changes order of list view
        private void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), scheduleListView, scheduleComboBox);
        }

        // changes order of list view
        private void itineraryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(ApplicationManager.i.mainUser.getItinerary(), itineraryListView, itineraryComboBox);
        }

        // changes permissions label to reflect currently selected user type
        private void userTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userTypeListBox.SelectedIndex >= 0)
            {
                UserType ut = (UserType)ApplicationManager.i.getObjectFromDbByName(new UserType(), userTypeListBox.SelectedItem.ToString());
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
                else if (ut.userPermissionsLevel == 2)
                {
                    permissionsLabel.Text = "Very limited access. Adds the ability to add or delete events from a personal itinerary." +
                        " The ability to view but not create or delete. Recommended for attendees/non-employees.";
                }
                else
                {
                    permissionsLabel.Text = "No access. The ability to view but not create or delete. Recommended for basic users.";
                }
            }
        }

        // saves the permissions level selected to the user type selected
        private void changePermissionsButton_Click(object sender, EventArgs e)
        {
            // making sure user type is selected
            if (userTypeListBox.SelectedIndex >= 0)
            {
                // cannot change Administrator or Basic user types
                if (userTypeListBox.SelectedItem.ToString() != "Administrator" && userTypeListBox.SelectedItem.ToString() != "Basic")
                {
                    if (permissionsComboBox.SelectedIndex != -1)
                    {
                        // checking with user to ensure they really want to delete the event type
                        if (MessageBox.Show("Are you sure you want to change the permissions for the " + userTypeListBox.SelectedItem.ToString() +
                            " user type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            UserType ut = new UserType();
                            ut.userTypeName = userTypeListBox.SelectedItem.ToString();
                            ut.userPermissionsLevel = permissionsComboBox.SelectedIndex;

                            MessageBox.Show(ApplicationManager.i.updateUserTypePermissions(ut));

                            loadUserTypes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A permissions level must be selected from the box");
                    }
                }
                else
                {
                    MessageBox.Show("The permissions levels for Administrator and Basic cannot be changed.");
                }  
            }
            else
            {
                MessageBox.Show("A user type must be selected in the list box.");
            }
        }

        // shows description of permission level
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
            else if (permissionsComboBox.SelectedIndex == 2)
            {
                permissionsLabel.Text = "Very limited access. Adds the ability to add or delete events from a personal itinerary." +
                    " The ability to view but not create or delete. Recommended for attendees/non-employees.";
            }
            else
            {
                permissionsLabel.Text = "No access. The ability to view but not create or delete. Recommended for basic users.";
            }
        }

        // shows assignment form
        private void assignButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignmentForm assignmentForm1 = new AssignmentForm();
            assignmentForm1.ShowDialog();
            this.Show();
        }

        // grants user type request
        private void grantButton_Click(object sender, EventArgs e)
        {
            // making sure something is selected
            if (userRequestsListView.SelectedItems.Count != 0)
            {
                MessageBox.Show(ApplicationManager.i.grantUserTypeRequest(userRequestsListView.SelectedItems[0].SubItems[1].Text));

                populateUserRequestListView(ApplicationManager.i.getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList(),
                userRequestsListView);
            }
            else
            {
                MessageBox.Show("A request from the list must be selected.");
            }
        }

        // denies user type request
        private void denyButton_Click(object sender, EventArgs e)
        {
            // making sure something is selected
            if (userRequestsListView.SelectedItems.Count != 0)
            {
                MessageBox.Show(ApplicationManager.i.denyUserTypeRequest(userRequestsListView.SelectedItems[0].SubItems[1].Text));

                populateUserRequestListView(ApplicationManager.i.getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList(),
                userRequestsListView);
            }
            else
            {
                MessageBox.Show("A request from the list must be selected.");
            }
        }

        // allows the user to double click an event to see more details about it
        private void scheduleListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = scheduleListView.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            // making sure something was selected
            if (item != null)
            {
                foreach (Event eve in ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList())
                {
                    // the if statement is written this way due to how the double click feature reads from the listview,
                    // so it has to look like this for it work
                    if (eve.startTime.ToString("MM/dd h:mm tt") + " - " + (eve.startTime + eve.eventDuration).ToString("t") == item.Text)
                    {
                        EventDetailsForm DetailedView = new EventDetailsForm();
                        DetailedView.PopulateForm(eve.eventName,  eve.description);
                        DetailedView.Show();
                    }
                }
            }
        }

        // sends email
        private void sendEmailButton_Click_1(object sender, EventArgs e)
        {
            StringBuilder body = new StringBuilder();
            body.Append(bodyTextBox.Text);

            // sending email and displaying result of operation
            string message = ApplicationManager.i.sendEmail(emailAddresses[toComboBox.SelectedIndex],
                subjectTextBox.Text, body.ToString());

            // if email went through successfully clear fields
            if (message == "The email has been sent successfully")
            {
                subjectTextBox.Clear();
                bodyTextBox.Clear();
            }

            MessageBox.Show(message);
        }

        // when user clicks in text box
        private void eventTypeTextBox_Enter(object sender, EventArgs e)
        {
            if (eventTypeTextBox.Text == "New Event Type")
            {
                eventTypeTextBox.Text = "";
                eventTypeTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void eventTypeTextBox_Leave(object sender, EventArgs e)
        {
            if (eventTypeTextBox.Text == "")
            {
                eventTypeTextBox.Text = "New Event Type";
                eventTypeTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void locationTextBox_Enter(object sender, EventArgs e)
        {
            if (locationTextBox.Text == "New Location")
            {
                locationTextBox.Text = "";
                locationTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void locationTextBox_Leave(object sender, EventArgs e)
        {
            if (locationTextBox.Text == "")
            {
                locationTextBox.Text = "New Location";
                locationTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void userTypeTextBox_Enter(object sender, EventArgs e)
        {
            if (userTypeTextBox.Text == "New User Type")
            {
                userTypeTextBox.Text = "";
                userTypeTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void userTypeTextBox_Leave(object sender, EventArgs e)
        {
            if (userTypeTextBox.Text == "")
            {
                userTypeTextBox.Text = "New User Type";
                userTypeTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void changeUsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (changeUsernameTextBox.Text == "New Username")
            {
                changeUsernameTextBox.Text = "";
                changeUsernameTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void changeUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (changeUsernameTextBox.Text == "")
            {
                changeUsernameTextBox.Text = "New Username";
                changeUsernameTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void changePasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (changePasswordTextBox.Text == "New Password")
            {
                changePasswordTextBox.Text = "";
                changePasswordTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void changePasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (changePasswordTextBox.Text == "")
            {
                changePasswordTextBox.Text = "New Password";
                changePasswordTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void conventionTitleTextBox_Enter(object sender, EventArgs e)
        {
            if (conventionTitleTextBox.Text == "Enter the convention title here.")
            {
                conventionTitleTextBox.Text = "";
                conventionTitleTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void conventionTitleTextBox_Leave(object sender, EventArgs e)
        {
            if (conventionTitleTextBox.Text == "")
            {
                conventionTitleTextBox.Text = "Enter the convention title here.";
                conventionTitleTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void conventionSubtitleTextBox_Enter(object sender, EventArgs e)
        {
            if (conventionSubtitleTextBox.Text == "Enter the convention subtitle here.")
            {
                conventionSubtitleTextBox.Text = "";
                conventionSubtitleTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void conventionSubtitleTextBox_Leave(object sender, EventArgs e)
        {
            if (conventionSubtitleTextBox.Text == "")
            {
                conventionSubtitleTextBox.Text = "Enter the convention subtitle here.";
                conventionSubtitleTextBox.ForeColor = Color.DarkGray;
            }
        }

        // when user clicks in text box
        private void conventionDescriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (conventionDescriptionTextBox.Text == "Enter the convention description here.")
            {
                conventionDescriptionTextBox.Text = "";
                conventionDescriptionTextBox.ForeColor = Color.White;
            }
        }

        // when user clicks out of text box
        private void conventionDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (conventionDescriptionTextBox.Text == "")
            {
                conventionDescriptionTextBox.Text = "Enter the convention description here.";
                conventionDescriptionTextBox.ForeColor = Color.DarkGray;
            }
        }

        // displays the general information entered on the screen
        private void conventionDisplayButton_Click(object sender, EventArgs e)
        {
            if (conventionTitleTextBox.ForeColor == Color.White)
            {
                conventionTitleLabel.Text = conventionTitleTextBox.Text;
            }

            if (conventionSubtitleTextBox.ForeColor == Color.White)
            {
                conventionSubtitleLabel.Text = conventionSubtitleTextBox.Text;
            }

            if (conventionDisplayDescTextBox.ForeColor == Color.White)
            {
                conventionDisplayDescTextBox.Text = conventionDescriptionTextBox.Text;
            }
        }

        // saves the general information about the convention to the database
        private void conventionSaveButton_Click(object sender, EventArgs e)
        {
            // making sure fields aren't blank
            if (conventionTitleLabel.ForeColor == Color.White && conventionSubtitleLabel.ForeColor == Color.White
                && conventionDisplayDescTextBox.ForeColor == Color.White)
            {
                MessageBox.Show(ApplicationManager.i.saveGeneralInfo(conventionTitleLabel.Text,
                    conventionSubtitleLabel.Text, conventionDisplayDescTextBox.Text));
            }
            else
            {
                MessageBox.Show("All fields must be filled in.");
            }
        }

        private void eventTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventTypeListBox.SelectedIndex >= 0)
            {
                EventType et = (EventType)ApplicationManager.i.getObjectFromDbByName(new EventType(), eventTypeListBox.SelectedItem.ToString());
                colorLabel.BackColor = Color.FromArgb(et.eventTypeColor);
            }
        }

        // selects color
        private void colorLabel_Click(object sender, EventArgs e)
        {
            // making sure a color was selected
            if (eventTypeColorDialog.ShowDialog() == DialogResult.OK)
            {
                colorLabel.BackColor = eventTypeColorDialog.Color;
            }
        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {
            // making sure event type is selected
            if (eventTypeListBox.SelectedIndex >= 0)
            {
                // checking with user to ensure they really want to change the color
                if (MessageBox.Show("Are you sure you want to change the color for " + eventTypeListBox.SelectedItem.ToString() +
                    " Event Type?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EventType et = new EventType();
                    et.eventTypeName = eventTypeListBox.SelectedItem.ToString();
                    et.eventTypeColor = colorLabel.BackColor.ToArgb();

                    MessageBox.Show(ApplicationManager.i.updateEventTypeColor(et));

                    loadEventTypes();
                }
            }
            else
            {
                MessageBox.Show("A type must be selected in the list box.");
            }
        }

        // emails user's itinerary to them
        private void emailItineraryLabel_Click(object sender, EventArgs e)
        {
            // loops through itinerary listview and concatenates string with items
            string emailBodyWhole = "";
            foreach (ListViewItem lvi in itineraryListView.Items)
            {
                string emailBodyLine = "Time: " + lvi.SubItems[0].Text + "\nEvent: " + lvi.SubItems[1].Text +
                    "\nType: " + lvi.SubItems[2].Text + "\nLocation: " + lvi.SubItems[3].Text;

                emailBodyWhole += emailBodyLine + "\n\n";
            }

            // sending email
            MessageBox.Show(ApplicationManager.i.sendEmail(ApplicationManager.i.mainUser.userEmail,
                "Venzi: Your Itinerary", emailBodyWhole));
        }

        // when mouse hovers over label
        private void emailItineraryLabel_MouseEnter(object sender, EventArgs e)
        {
            emailItineraryLabel.Font = new Font(emailItineraryLabel.Font.FontFamily, 9);
            emailItineraryLabel.ForeColor = Color.FromArgb(120, 255, 255);
        }

        // when mouse leaves label
        private void emailItineraryLabel_MouseLeave(object sender, EventArgs e)
        {
            emailItineraryLabel.Font = new Font(emailItineraryLabel.Font.FontFamily, 8);
            emailItineraryLabel.ForeColor = Color.FromArgb(60, 150, 255);
        }
    }
}