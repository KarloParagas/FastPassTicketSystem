using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPassTicketSystem
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create an instance of the user's input so it can be accessed in other forms
        /// </summary>
        public static Options input = new Options();

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //Create an Options object and set the user's input to it's properties
            if (IsDataValid() == true) 
            {
                Options i = new Options()
                {
                    //Extract all input
                    MinutesPerWindow = Convert.ToInt32(MinutesPerWindowTxt.Text),
                    GuestsPerWindow = Convert.ToInt32(GuestsPerWindowTxt.Text),
                    StartTime = Convert.ToDateTime(StartTimeTxt.Text),
                    EndTime = Convert.ToDateTime(EndTimeTxt.Text),
                    FirstTicketNumber = Convert.ToInt32(FirstTicketNumTxt.Text)             
                };

                //Assign the Options object with all the extrated user input to the UserInput instance
                //so it can be accessed in other forms
                input = i;

                DialogResult = DialogResult.OK;            
            }
        }

        private bool IsDataValid()
        {
            if (IsPresent() == true && IsInputValid() == true) 
            {
                return true;
            }
            return false;
        }

        private bool IsInputValid()
        {
            //Variables to be used for testing, for valid integer and date time input
            int validInteger;
            DateTime validDateTime;

            if (!DateTime.TryParse(StartTimeTxt.Text, out validDateTime) ||
                !DateTime.TryParse(EndTimeTxt.Text, out validDateTime))  
            {
                MessageBox.Show("Start time and End time must be a valid date time input. Ex: (10:00 AM/PM)");
                return false;
            }
            if (!int.TryParse(MinutesPerWindowTxt.Text, out validInteger) ||
                !int.TryParse(GuestsPerWindowTxt.Text, out validInteger) ||
                !int.TryParse(FirstTicketNumTxt.Text, out validInteger)) 
            {
                MessageBox.Show("Minutes per window, Guests per window, and " +
                                "First ticket number must be a valid integer input.");
                return false;
            }
            if (Convert.ToInt32(FirstTicketNumTxt.Text) > Convert.ToInt32(GuestsPerWindowTxt.Text)) 
            {
                MessageBox.Show("First ticket number cannot be greater than the guests per window");
                return false;
            }

            return true;
        }

        private bool IsPresent()
        {
            if (string.IsNullOrWhiteSpace(MinutesPerWindowTxt.Text) || 
                string.IsNullOrWhiteSpace(GuestsPerWindowTxt.Text) ||
                string.IsNullOrWhiteSpace(StartTimeTxt.Text) ||
                string.IsNullOrWhiteSpace(EndTimeTxt.Text) ||
                string.IsNullOrWhiteSpace(FirstTicketNumTxt.Text)) 
            {
                MessageBox.Show("Cannot submit an empty form");
                return false;
            }
            return true;
        }
    }
}
