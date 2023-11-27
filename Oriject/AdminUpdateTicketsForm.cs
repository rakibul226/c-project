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
    public partial class AdminUpdateTicketsForm : Form
    {
        public AdminUpdateTicketsForm()
        {
            InitializeComponent();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (txtFlightNo.Text == "")
            {
                MessageBox.Show("Please enter a flight number.");
            }
            else
            {
                if (dtpDate.Text == "" || dtpTime.Text == "" || cbFrom.Text == "" || cbTo.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Failed to update. Please fill up all the details.");
                }
                else
                {
                    ETicket eTicket = new ETicket();
                    eTicket.FlightNo = txtFlightNo.Text;
                    eTicket.Date = dtpDate.Text;
                    eTicket.Time = dtpTime.Text;
                    eTicket.FlightFrom = cbFrom.Text;
                    eTicket.FlightTo = cbTo.Text;
                    eTicket.Price = txtPrice.Text;

                    OTicket oTicket = new OTicket();
                    int effectedRows = oTicket.UpdateTicket(eTicket);

                    if (effectedRows > 0)
                    {
                        MessageBox.Show("Updated successfully.");
                        txtFlightNo.Clear();
                        txtPrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update. Please enter a valid flight number.");
                    }
                }
            }


        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }

       
        private void AdminUpdateTicketsForm_Load(object sender, EventArgs e)
        {
            dtpTime.CustomFormat = "HH:mm";
        }
    }
}