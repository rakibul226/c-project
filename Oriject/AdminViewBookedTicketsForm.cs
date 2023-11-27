﻿using AT.Entities;
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
    public partial class AdminViewBookedTicketsForm : Form
    {
        public AdminViewBookedTicketsForm()
        {
            InitializeComponent();
        }

        private void AdminViewBookedTicketsForm_Load(object sender, EventArgs e)
        {
            OTicket oTicket = new OTicket();
            dgvBookedTickets.DataSource = oTicket.ViewAllBookedTickets();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }
    }
}
