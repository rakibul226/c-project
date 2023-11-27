using AT.Entities;
using AT.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirwayTicketingApplication
{
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private void btnViewAvailableTickets_Click(object sender, EventArgs e)
        {
            new UserViewAllTicketsForm().Show();
            this.Hide();
        }

        private void btnViewBookedTickets_Click(object sender, EventArgs e)
        {
            new UserViewBookedTicketsForm().Show();
            this.Hide();
        }

        private void btnBookTickets_Click(object sender, EventArgs e)
        {
            new UserBookTicketsForm().Show();
            this.Hide();
        }

        private void btnCancelTickets_Click(object sender, EventArgs e)
        {
            new UserCancelTicketsForm().Show();
            this.Hide();
        }
        private void linkLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
