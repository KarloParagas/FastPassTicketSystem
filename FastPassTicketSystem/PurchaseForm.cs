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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseTicket_Click(object sender, EventArgs e)
        {
            //Create a purchase object
            CustomerPurchase cp = new CustomerPurchase() 
            {
                FirstName = FirstNameTxt.Text,
                LastName = LastNameTxt.Text,
                Email = EmailTxt.Text,
                PhoneNumber = PhoneNumberTxt.Text
            };

            //Add the purchase to the database
            CustomerPurchaseDb.Add(cp);
            MessageBox.Show($"Ticket {cp.TicketNumber} successfully purchased");
        }
    }
}
