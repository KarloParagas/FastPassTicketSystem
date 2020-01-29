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
        public TicketForm()
        {
            InitializeComponent();
            OptionsForm options = new OptionsForm();
            DialogResult result = options.ShowDialog();
            if (result == DialogResult.OK) 
            {
                TitleBarTime.Start();            
            }

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
    }
}
