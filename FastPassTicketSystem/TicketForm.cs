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
        int outstandingTickets = 0;

        //Keeps track of the minutes to be added
        int minutes;

        //Keeps track of the current entry time
        DateTime nextEntryTime;

        //Keeps track of the last entry time
        DateTime nextEntryTimeDisplay;

        //Keeps track of the ticket to be issued
        int Ticket;

        //Keeps track of the next ticket that can enter
        int nextEntryTicket;

        public TicketForm()
        {
            InitializeComponent();

            OptionsForm options = new OptionsForm();
            DialogResult r = options.ShowDialog();
            if (r == DialogResult.OK) 
            {
                TitleBarTime.Start();            
            }            
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            //Create a database context to access the database
            CustomerPurchaseContext db = new CustomerPurchaseContext();

            //Set the amount of minuted to be added based on the user input in the OptionsForm
            minutes = OptionsForm.input.MinutesPerWindow;

            //Set next entry time based on minutes per window that the user input in the options form
            nextEntryTime = DateTime.Now.AddMinutes(minutes).AddSeconds(-DateTime.Now.Second);

            //Set the next entry time display (only used for the list box)
            nextEntryTimeDisplay = nextEntryTime;

            //Set the ticket to be issued
            Ticket = 0;

            //Set the next entry ticket
            nextEntryTicket = 0;

            //Display the guests with following tickets that can enter
            GuestsEnterLabel.Text = Ticket.ToString();

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

            //Only update "guests with the following tickets may now enter" only when the next available entry time has been reached
            //and when the list box isnt empty
            if (currentTime.ToString().Equals(nextEntryTime.ToString()) && listBox1.Items.Count != 0)
            {
                nextEntryTicket++;

                GuestsEnterLabel.Text = nextEntryTicket.ToString(); //Not displaying the right ticket

                nextEntryTime = nextEntryTime.AddMinutes(minutes);
                NextEntryLabel.Text = nextEntryTime.ToShortTimeString().ToString();

                //Remove the first item in the listBox since that time has now passed and decrement total tickets outstanding
                listBox1.Items.RemoveAt(0);
                outstandingTickets--;
                TotalTicketsLabel.Text = outstandingTickets.ToString();
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
        private void IssueTicket()
        {
            //Only add more minutes if there are outstanding tickets issued
            if (outstandingTickets > 0)
            {
                //Add more minutes to the last entry time
                nextEntryTimeDisplay = nextEntryTimeDisplay.AddMinutes(minutes);
            }

            //Increment the ticket to be issued
            Ticket++;

            //Add the next ticket and their time slot to the listbox
            listBox1.Items.Add($"Ticket {Ticket.ToString()}: " +
                $"{nextEntryTimeDisplay.ToShortTimeString().ToString()}");

            //Add one to total tickets outstanding everytime the issue button gets clicked
            outstandingTickets++;
            TotalTicketsLabel.Text = outstandingTickets.ToString();
        }

        private void PurchaseTicket_Click(object sender, EventArgs e)
        {
            //Display the purchase ticket form
            PurchaseForm purchase = new PurchaseForm();
            DialogResult result = purchase.ShowDialog();
            if (result == DialogResult.OK) 
            {
                IssueTicket();
            }
        }
    }
}
