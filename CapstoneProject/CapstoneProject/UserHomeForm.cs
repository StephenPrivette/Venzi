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
            Apex.i.loadEvents();
            foreach(List<string> row in Apex.i.events)
            {
                scheduleListBox.Items.Add(row[7] + "\t" + row[1] + "\t" + row[3] + "\t" + row[8] + "\t" + row[2]);
            }

            Apex.i.loadItinerary(Apex.i.mainUser.userName);
            foreach (List<string> row in Apex.i.events)
            {
                foreach (List<string> rower in Apex.i.mainUser.itinerary)
                {
                    if (row[0] == rower[0])
                    {
                        itineraryListBox.Items.Add(row[7] + "\t" + row[1] + "\t" + row[3] + "\t" + row[8] + "\t" + row[2]);
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Currently has bug where if no item is selected program will crash, will fix in next iteration.
            Apex.i.db.addEventToItinerary(Apex.i.mainUser.userName, Apex.i.events[scheduleListBox.SelectedIndex][0]);

            Apex.i.loadItinerary(Apex.i.mainUser.userName);
            itineraryListBox.Items.Clear();
            foreach (List<string> row in Apex.i.events)
            {
                foreach (List<string> rower in Apex.i.mainUser.itinerary)
                {
                    if (row[0] == rower[0])
                    {
                        itineraryListBox.Items.Add(row[7] + "\t" + row[1] + "\t" + row[3] + "\t" + row[8] + "\t" + row[2]);
                    }
                }
            }
        }

        private void deleteItineraryItem_Click(object sender, EventArgs e)
        {
            // Currently has bug where if no item is selected program will crash, will fix in next iteration.
            Apex.i.db.deleteItineraryEvent(Apex.i.mainUser.userName, Apex.i.mainUser.itinerary[itineraryListBox.SelectedIndex][0]);

            Apex.i.loadItinerary(Apex.i.mainUser.userName);
            itineraryListBox.Items.Clear();
            foreach (List<string> row in Apex.i.events)
            {
                foreach (List<string> rower in Apex.i.mainUser.itinerary)
                {
                    if (row[0] == rower[0])
                    {
                        itineraryListBox.Items.Add(row[7] + "\t" + row[1] + "\t" + row[3] + "\t" + row[8] + "\t" + row[2]);
                    }
                }
            }
        }
    }
}
