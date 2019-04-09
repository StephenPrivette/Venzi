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
            // on load populate info
            populateEventListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList().OrderBy(x => x.startTime).ToList(), eventsListView);

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
                Event currentEvent = (Event)Apex.i.getObjectFromDbByName(new Event(), eventsListView.SelectedItems[0].SubItems[1].Text);

                nameTextBox.Text = currentEvent.eventName;
                startTimePicker1.Value = currentEvent.startTime;
                startTimePicker2.Value = currentEvent.startTime;
                eventDurationTextBox.Text = currentEvent.eventDuration.ToString();
                setupDurationTextBox.Text = currentEvent.setupDuration.ToString();
                breakdownDurationTextBox.Text = currentEvent.breakdownDuration.ToString();
                descriptionRichTextBox.Text = currentEvent.description;
                eventTypeListBox.SelectedItem = currentEvent.eventTypeName;
                locationListBox.SelectedItem = currentEvent.locationName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (eventTypeListBox.SelectedIndex >= 0 && locationListBox.SelectedIndex >= 0 &&
                eventDurationTextBox.MaskCompleted && setupDurationTextBox.MaskCompleted &&
                breakdownDurationTextBox.MaskCompleted)
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
                            eDur, sDur, bDur, descriptionRichTextBox.Text));

                            populateEventListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList().OrderBy(x => x.startTime).ToList(), eventsListView);
                            // clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Durations must be no greater than 12:59.");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to create a new event named " + nameTextBox.Text,
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
                            eDur, sDur, bDur, descriptionRichTextBox.Text));

                            populateEventListView(Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList().OrderBy(x => x.startTime).ToList(), eventsListView);
                            // clearFields();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
