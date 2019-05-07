using CapstoneClassLibrary;
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
    // form for assigning users with permission levels of 1 to events
    public partial class AssignmentForm : Form
    {
        // needed a way to have a list of just usernames with the same index as the combo box 
        List<string> allStaffUsernames;
        List<string> assignedStaffUsernames;

        public AssignmentForm()
        {
            InitializeComponent();
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            allStaffUsernames = new List<string>();
            assignedStaffUsernames = new List<string>();

            eventsComboBox.SelectedIndex = 0;
            staffComboBox.SelectedIndex = 0;

            populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);

            loadAllStaff();
        }

        // populates the listviews on this form with data
        private void populateListView(List<Event> events, ListView lv, ComboBox cb)
        {
            lv.SelectedItems.Clear();
            lv.Items.Clear();

            // orders list for listView based on comboBox setting
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

            // populating listView
            foreach (Event i in events)
            {
                ListViewItem lvItem = new ListViewItem((i.startTime - i.setupDuration).ToString("MM/dd h:mm tt"));
                lvItem.SubItems.Add(i.startTime.ToString("h:mm tt"));
                lvItem.SubItems.Add((i.startTime + i.eventDuration).ToString("h:mm tt"));
                lvItem.SubItems.Add((i.startTime + i.eventDuration + i.breakdownDuration).ToString("h:mm tt"));
                lvItem.SubItems.Add(i.eventName);
                lvItem.SubItems.Add(i.eventTypeName);
                lvItem.SubItems.Add(i.locationName);
                lvItem.SubItems.Add(i.staffRequired.ToString());
                lvItem.SubItems.Add(i.staffAssigned.ToString());
                lv.Items.Add(lvItem);
            }
        }

        // method for populating all staff listBox
        private void loadAllStaff()
        {
            allStaffUsernames.Clear();
            allStaffComboBox.SelectedIndex = -1;
            allStaffComboBox.Items.Clear();

            List<UserType> allUserTypes = ApplicationManager.i.getAllFromTable(new UserType()).Cast<UserType>().ToList();

            // for all users
            foreach (User u in ApplicationManager.i.getAllFromTable(new User()).Cast<User>().ToList())
            {

                // for all user types
                foreach (UserType type in allUserTypes)
                {
                    // if user type is a staff type
                    if(type.userPermissionsLevel == 1)
                    {
                        // if user is a staff user
                        if (type.userTypeName == u.userTypeName)
                        {
                            // populated list box with all staff users
                            allStaffComboBox.Items.Add(u.userName + ", " + u.userFirstName + " "
                                + u.userLastName + " (" + u.userTypeName + ")");
                            allStaffUsernames.Add(u.userName);
                        }
                    }
                }
            }

            if (allStaffComboBox.Items.Count > 0)
            {
                allStaffComboBox.SelectedIndex = 0;
            }
        }

        // method for populating assigned listBox with only staff assigned to selected event
        private void loadAssignedStaff()
        {
            assignedStaffUsernames.Clear();
            assignedStaffComboBox.SelectedIndex = -1;
            assignedStaffComboBox.Items.Clear();

            Event currentEvent = (Event)ApplicationManager.i.getObjectFromDbByName(new Event(),
                eventsListView.SelectedItems[0].SubItems[4].Text);

            // for all staff assigned to selected event
            foreach (User staff in ApplicationManager.i.getStaffAssignedToEvent(currentEvent.eventID))
            {
                assignedStaffComboBox.Items.Add(staff.userName + ", " + staff.userFirstName + " "
                    + staff.userLastName + " (" + staff.userTypeName + ")");
                assignedStaffUsernames.Add(staff.userName);
            }

            if (assignedStaffComboBox.Items.Count > 0)
            {
                assignedStaffComboBox.SelectedIndex = 0;
            }
        }

        // changes listView order
        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
        }

        // when a user is selected we want to show their itinerary
        private void allStaffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allStaffComboBox.SelectedIndex > -1)
            {
                User selectedStaffer = (User)ApplicationManager.i.getObjectFromDbByName(new User(),
                    allStaffUsernames[allStaffComboBox.SelectedIndex]);

                populateListView(ApplicationManager.i.getItineraryFromDb(selectedStaffer.userID).Cast<Event>().ToList(),
                    staffListView, staffComboBox);
            }
        }

        // load assigned staff for currently selected event
        private void eventsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsListView.SelectedIndices.Count > 0)
            {
                loadAssignedStaff();
            }
        }

        // removes staff from event
        private void removeButton_Click(object sender, EventArgs e)
        {
            if(eventsListView.SelectedItems.Count > 0)
            {
                if (assignedStaffComboBox.SelectedIndex > -1)
                {
                    // unassigning staff from event
                    MessageBox.Show(ApplicationManager.i.deleteEventFromItinerary(eventsListView.SelectedItems[0].SubItems[4].Text,
                        assignedStaffUsernames[assignedStaffComboBox.SelectedIndex]));

                    loadAssignedStaff();
                    populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(),
                        eventsListView, eventsComboBox);
                }
                else
                {
                    MessageBox.Show("An assigned staff member must be selected in order to unassign them from an event.");
                }
            }
            else
            {
                MessageBox.Show("An event must be selected in order to unassign a staff member from it.");
            }
        }

        // assigns staff user to event
        private void assignButton_Click(object sender, EventArgs e)
        {
            if (eventsListView.SelectedIndices.Count > 0)
            {
                if (allStaffComboBox.SelectedIndex > -1)
                {
                    // assigning staff to event
                    MessageBox.Show(ApplicationManager.i.assignStaffToEvent(eventsListView.SelectedItems[0].SubItems[4].Text,
                        allStaffUsernames[allStaffComboBox.SelectedIndex]));

                    loadAssignedStaff();
                    populateListView(ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView,
                        eventsComboBox);

                    if (allStaffComboBox.SelectedIndex > -1)
                    {
                        User selectedStaffer = (User)ApplicationManager.i.getObjectFromDbByName(new User(),
                            allStaffUsernames[allStaffComboBox.SelectedIndex]);

                        populateListView(ApplicationManager.i.getItineraryFromDb(selectedStaffer.userID).Cast<Event>().ToList(),
                            staffListView, staffComboBox);
                    }
                }
                else
                {
                    MessageBox.Show("A staffer must be selected from the list box in order to assign them to an event.");
                }
            }
            else
            {
                MessageBox.Show("An event must be selected from the list view in order to assign someone to it.");
            }
        }

        // exits form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
