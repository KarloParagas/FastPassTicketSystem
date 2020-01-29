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
    public partial class TicketForm : Form
    {
        //Keeps track of the outstanding tickets issued
        int count = 0;

        //Keeps track of the current ticket
        int currentTicket;

        //Keeps track of the minutes to be added
        int minutes;

        public TicketForm()
        {
            InitializeComponent();
            OptionsForm options = new OptionsForm();
            DialogResult result = options.ShowDialog();
            if (result == DialogResult.OK) 
            {
                TitleBarTime.Start();            
            }
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            //Set the current ticket using the user input from the OptionsForm
            currentTicket = OptionsForm.input.GuestsPerWindow;

            //Set the amount of minuted to be added based on the user input in the OptionsForm
            minutes = OptionsForm.input.MinutesPerWindow;

            //Display the guests with following tickets that can enter
            GuestsEnterLabel.Text = $"{OptionsForm.input.FirstTicketNumber.ToString()} - " +
                                    $"{(OptionsForm.input.GuestsPerWindow + OptionsForm.input.FirstTicketNumber - 1).ToString()}";

            //Display next available entry
            NextEntryLabel.Text = DateTime.Now.AddMinutes(OptionsForm.input.MinutesPerWindow).ToShortTimeString().ToString();
        }

        /// <summary>
        /// Displays current time in the title bar. Updates once per second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBarTime_Tick(object sender, EventArgs e)
        {
            //Grab the current time, start time from the Options form
            DateTime open = OptionsForm.input.StartTime;
            DateTime currentTime = DateTime.Now;


            if (currentTime < open)
            {
                this.Text = $"{DateTime.Now.ToString()} (Closed)";
            }
            else 
            {
                this.Text = $"{DateTime.Now.ToString()} (Open)";
            }
        }

        /// <summary>
        /// Closes the ticket form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Issues the next ticket and adds it to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IssueTicketBtn_Click(object sender, EventArgs e)
        {
            //Increment the current ticket for the next ticket to be issued
            currentTicket++;

            //Add one to total tickets outstanding everytime the issue button gets clicked
            count++;
            TotalTicketsLabel.Text = count.ToString();

            //Update next available entry
            NextEntryLabel.Text = DateTime.Now.AddMinutes(minutes).ToShortTimeString().ToString(); //Currently doesn't update

            //Update the next available entry
            GuestsEnterLabel.Text = currentTicket.ToString();

            //Add the next ticket and time to the listbox
            listBox1.Items.Add($"Ticket {currentTicket.ToString()}: " +
                $"{DateTime.Now.AddMinutes(OptionsForm.input.MinutesPerWindow).ToShortTimeString().ToString()}");
        }

        //TODO: Once the next available entry time has passed, add more minutes 
        //based on the options setting (minutes per window) , and update next available entry
    }
}
