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

        }

        /// <summary>
        /// Displays current time in the title bar. Updates once per second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBarTime_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("h:mm:ss") + " (Open)";
        }
    }
}
