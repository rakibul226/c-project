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
    public partial class UserBookTicketsForm : Form
    {
        public UserBookTicketsForm()
        {
            InitializeComponent();
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            string from = cbFrom.Text;
            string to = cbTo.Text;
            OTicket oTicket = new OTicket();
            dgvAvailableTickets.DataSource = oTicket.SearchAvailableTickets(from, to);
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {

            if (txtFlightNo.Text == "")
            {
                MessageBox.Show("Please enter a flight number.");
            }
            else
            {
                ETicket eTicket = new ETicket();
                eTicket.FlightNo = txtFlightNo.Text;

                OTicket oTicket = new OTicket();
                DataTable dt = new DataTable();
                dt = oTicket.IsValidTicket(eTicket);

                if (dt.Rows.Count > 0)
                {
                    if (string.IsNullOrEmpty(dt.Rows[0]["BookedBy"].ToString()))
                    {
                        int effectedRows = oTicket.BookTicket(eTicket);

                        if (effectedRows > 0)
                        {
                            MessageBox.Show("Ticket booked successfully.");
                            txtFlightNo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to book ticket. Please enter a valid flight number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to book ticket. Please enter a valid flight number.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to book ticket. Please enter a valid flight number.");
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
