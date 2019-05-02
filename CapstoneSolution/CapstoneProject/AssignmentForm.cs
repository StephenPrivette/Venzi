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
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            eventsComboBox.SelectedIndex = 0;
            staffComboBox.SelectedIndex = 0;

            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);

            loadAllStaff();
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

        // method for populating event type list box
        private void loadAllStaff()
        {
            allStaffListBox.SelectedItems.Clear();
            allStaffListBox.Items.Clear();

            List<UserType> allUserTypes = Apex.i.getAllFromTable(new UserType()).Cast<UserType>().ToList();

            foreach (User u in Apex.i.getAllFromTable(new User()).Cast<User>().ToList())
            {
                foreach (UserType type in allUserTypes)
                {
                    if(type.userPermissionsLevel == 1)
                    {
                        if (type.userTypeName == u.userTypeName)
                        {
                            allStaffListBox.Items.Add(u.userName + " " + u.userFirstName + " "
                                + u.userLastName + " (" + u.userTypeName + ")");
                        }
                    }
                }
            }
        }

        private void loadAssignedStaff()
        {
            assignedListBox.SelectedItems.Clear();
            assignedListBox.Items.Clear();

            Event currentEvent = (Event)Apex.i.getObjectFromDbByName(new Event(), eventsListView.SelectedItems[0].SubItems[4].Text);

            foreach (User staff in Apex.i.getStaffAssignedToEvent(currentEvent.eventID))
            {
                assignedListBox.Items.Add(staff.userName + " " + staff.userFirstName + " " + staff.userLastName + " (" + staff.userTypeName + ")");
            }
        }

        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
        }

        private void allStaffListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allStaffListBox.SelectedIndex >= 0)
            {
                int length = 0;
                foreach (char ch in allStaffListBox.SelectedItem.ToString())
                {
                    if (Char.IsWhiteSpace(ch))
                    {
                        break;
                    }
                    length++;
                }

                User selectedStaffer = (User)Apex.i.getObjectFromDbByName(new User(),
                    allStaffListBox.SelectedItem.ToString().Substring(0, length));

                populateListView(Apex.i.getItineraryFromDb(selectedStaffer.userID).Cast<Event>().ToList(), staffListView, staffComboBox);
            }
        }

        private void eventsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsListView.SelectedIndices.Count > 0)
            {
                loadAssignedStaff();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(eventsListView.SelectedItems.Count > 0)
            {
                if (assignedListBox.SelectedItems.Count > 0)
                {
                    int length = 0;
                    foreach (char ch in assignedListBox.SelectedItem.ToString())
                    {
                        if (Char.IsWhiteSpace(ch))
                        {
                            break;
                        }
                        length++;
                    }

                    User selectedAssignedStaffer = (User)Apex.i.getObjectFromDbByName(new User(),
                        assignedListBox.SelectedItem.ToString().Substring(0, length));

                    List<Event> selectedAssignedItinerary = Apex.i.getItineraryFromDb(selectedAssignedStaffer.userID);

                    Event currentEvent = (Event)Apex.i.getObjectFromDbByName(new Event(), eventsListView.SelectedItems[0].SubItems[4].Text);

                    int itineraryIdToDelete = 0;
                    foreach (Event eve in selectedAssignedItinerary)
                    {
                        if (eve.eventID == currentEvent.eventID)
                        {
                            itineraryIdToDelete = eve.eventID;
                        }
                    }

                    Apex.i.deleteEventFromItinerary(selectedAssignedStaffer.userID, itineraryIdToDelete);

                    loadAssignedStaff();
                    populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
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

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (eventsListView.SelectedIndices.Count > 0)
            {
                if (allStaffListBox.SelectedIndex >= 0)
                {
                    int length = 0;
                    foreach (char ch in allStaffListBox.SelectedItem.ToString())
                    {
                        if (Char.IsWhiteSpace(ch))
                        {
                            break;
                        }
                        length++;
                    }

                    Apex.i.assignStaffToEvent(eventsListView.SelectedItems[0].SubItems[4].Text,
                        allStaffListBox.SelectedItem.ToString().Substring(0, length));

                    loadAssignedStaff();
                    populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
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
    }
}
