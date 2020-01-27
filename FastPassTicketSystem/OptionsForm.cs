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

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == true) 
            {
                //Extract all input

                //Assign it to the time slot class

                //Store it in a collection

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
