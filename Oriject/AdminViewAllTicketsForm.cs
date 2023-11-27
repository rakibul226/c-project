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
    public partial class AdminViewAllTicketsForm : Form
    {
        public AdminViewAllTicketsForm()
        {
            InitializeComponent();
        }
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }

        private void AdminViewAllTicketsForm_Load(object sender, EventArgs e)
        {
            ETicket eTicket = new ETicket();
            OTicket oTicket = new OTicket();
            dgvAllTickets.DataSource = oTicket.ViewAllTickets(eTicket);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }
    }
}
