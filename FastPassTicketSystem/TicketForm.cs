﻿using System;
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

        //Keeps track of the minutes to be added
        int minutes;

        //Keeps track of the current entry time
        DateTime nextEntryTime;

        //Keeps track of the next ticket to be issued
        int nextTicket;

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

            //Set the amount of minuted to be added based on the user input in the OptionsForm
            minutes = OptionsForm.input.MinutesPerWindow;

            //Set next entry time based on minutes per window that the user input in the options form
            nextEntryTime = DateTime.Now.AddMinutes(minutes).AddSeconds(-DateTime.Now.Second);

            //Set the next ticket to be issued
            nextTicket = OptionsForm.input.GuestsPerWindow + OptionsForm.input.FirstTicketNumber;

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
            DateTime currentTime = DateTime.Now.AddSeconds(-DateTime.Now.Second);

            if (currentTime < open)
            {
                this.Text = $"{DateTime.Now.ToString()} (Closed)";
            }
            else 
            {
                this.Text = $"{DateTime.Now.ToString()} (Open)";
            }

            //Fix: Only update "guests with the following tickets may now enter" only when the next available entry time has been reached
            //and when the list box isnt empty
            if (currentTime == nextEntryTime && listBox1.Items.Count != 0) 
            {
                GuestsEnterLabel.Text = nextTicket.ToString();
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
            //Only add more minutes if there are outstanding tickets issued
            if (count > 0) 
            {
                //Add more minutes to the next entry time
                nextEntryTime = nextEntryTime.AddMinutes(minutes);           
            }

            //Update the next entry time
            NextEntryLabel.Text = nextEntryTime.ToShortTimeString().ToString();

            //Update the next available entry
            //GuestsEnterLabel.Text = nextTicket.ToString();

            //Add the next ticket and time to the listbox
            listBox1.Items.Add($"Ticket {nextTicket.ToString()}: " +
                $"{nextEntryTime.ToShortTimeString().ToString()}");

            //Add one to total tickets outstanding everytime the issue button gets clicked
            count++;
            TotalTicketsLabel.Text = count.ToString();

            //Increment the next ticket to be issued
            nextTicket++;
        }

        //TODO: Make Options button functional
    }
}
