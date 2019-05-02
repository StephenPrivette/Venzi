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
    public partial class EventEditorForm : Form
    {
        public EventEditorForm()
        {
            InitializeComponent();
        }

        private void EventEditorForm_Load(object sender, EventArgs e)
        {
            eventsComboBox.SelectedIndex = 0;

            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);

            loadEventTypes();
            loadLocations();
        }

        // method for populating event type list box
        private void loadEventTypes()
        {
            eventTypeListBox.SelectedItems.Clear();
            eventTypeListBox.Items.Clear();

            foreach (EventType type in Apex.i.getAllFromTable(new EventType()).Cast<EventType>().ToList())
            {
                eventTypeListBox.Items.Add(type.eventTypeName);
            }
        }

        // method for populating location list box
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

        // clears all fields
        private void clearFields()
        {
            nameTextBox.Clear();
            startTimePicker1.Value = startTimePicker1.MinDate;
            startTimePicker2.Value = startTimePicker2.MinDate;
            eventDurationTextBox.Clear();
            setupDurationTextBox.Clear();
            breakdownDurationTextBox.Clear();
            descriptionRichTextBox.Clear();
            eventTypeListBox.ClearSelected();
            locationListBox.ClearSelected();
        }

        // when changing selection the form will populate with current highlighted event
        private void eventsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(eventsListView.SelectedIndices.Count > 0)
            {
                Event currentEvent = (Event)Apex.i.getObjectFromDbByName(new Event(), eventsListView.SelectedItems[0].SubItems[4].Text);

                nameTextBox.Text = currentEvent.eventName;
                startTimePicker1.Value = currentEvent.startTime;
                startTimePicker2.Value = currentEvent.startTime;
                eventDurationTextBox.Text = currentEvent.eventDuration.ToString();
                setupDurationTextBox.Text = currentEvent.setupDuration.ToString();
                breakdownDurationTextBox.Text = currentEvent.breakdownDuration.ToString();
                descriptionRichTextBox.Text = currentEvent.description;
                eventTypeListBox.SelectedItem = currentEvent.eventTypeName;
                locationListBox.SelectedItem = currentEvent.locationName;
                staffRequiredTextBox.Text = currentEvent.staffRequired.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (eventTypeListBox.SelectedIndex >= 0 && locationListBox.SelectedIndex >= 0 &&
                eventDurationTextBox.MaskCompleted && setupDurationTextBox.MaskCompleted &&
                breakdownDurationTextBox.MaskCompleted && staffRequiredTextBox.MaskCompleted)
            {
                if (Apex.i.isObjectNameInDb(new Event(), nameTextBox.Text))
                {
                    if (MessageBox.Show("Are you sure you want to overwrite the " + nameTextBox.Text +
                    " Event?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TimeSpan eDur = new TimeSpan();
                        TimeSpan sDur = new TimeSpan();
                        TimeSpan bDur = new TimeSpan();

                        if (TimeSpan.TryParse(eventDurationTextBox.Text, out eDur) &&
                            TimeSpan.TryParse(setupDurationTextBox.Text, out sDur) &&
                            TimeSpan.TryParse(breakdownDurationTextBox.Text, out bDur))
                        {
                            MessageBox.Show(Apex.i.editEvent(nameTextBox.Text, eventTypeListBox.SelectedItem.ToString(),
                            locationListBox.SelectedItem.ToString(), startTimePicker1.Value, startTimePicker2.Value,
                            eDur, sDur, bDur, descriptionRichTextBox.Text, int.Parse(staffRequiredTextBox.Text)));

                            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
                        }
                        else
                        {
                            MessageBox.Show("Durations must be no greater than 12:59.");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to create a new event named " + nameTextBox.Text + "?",
                        "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TimeSpan eDur = new TimeSpan();
                        TimeSpan sDur = new TimeSpan();
                        TimeSpan bDur = new TimeSpan();

                        if (TimeSpan.TryParse(eventDurationTextBox.Text, out eDur) &&
                            TimeSpan.TryParse(setupDurationTextBox.Text, out sDur) &&
                            TimeSpan.TryParse(breakdownDurationTextBox.Text, out bDur))
                        {
                            MessageBox.Show(Apex.i.editEvent(nameTextBox.Text, eventTypeListBox.SelectedItem.ToString(),
                            locationListBox.SelectedItem.ToString(), startTimePicker1.Value, startTimePicker2.Value,
                            eDur, sDur, bDur, descriptionRichTextBox.Text, int.Parse(staffRequiredTextBox.Text)));

                            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
                        }
                        else
                        {
                            MessageBox.Show("Durations must be no greater than 12:59.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields must be selected/filled in.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (eventsListView.SelectedIndices.Count > 0)
            {
                Event currentEvent = (Event)Apex.i.getObjectFromDbByName(new Event(), eventsListView.SelectedItems[0].SubItems[4].Text);

                // checking with user to ensure they really want to delete the event
                if (MessageBox.Show("Are you sure you want to delete the " + currentEvent.eventName +
                    " Event?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(Apex.i.deleteEventFromDb(new Event(), currentEvent.eventName));

                    populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);

                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("You must select an event from the list to delete.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList(), eventsListView, eventsComboBox);
        }
    }
}
