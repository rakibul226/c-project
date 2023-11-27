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
    public partial class UserViewAllTicketsForm : Form
    {
        public UserViewAllTicketsForm()
        {
            InitializeComponent();
        }


        private void UserViewAllTicketsForm_Load(object sender, EventArgs e)
        {
            EUser eUser = new EUser();
            OTicket oTicket = new OTicket();
            dgvAllTickets.DataSource = oTicket.ViewAllTickets(eUser);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
