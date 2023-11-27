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
    public partial class UserViewBookedTicketsForm : Form
    {
        public UserViewBookedTicketsForm()
        {
            InitializeComponent();
        }

        private void UserViewBookedTicketsForm_Load(object sender, EventArgs e)
        {
            OTicket oTicket = new OTicket();
            dgvBookedTickets.DataSource = oTicket.ViewBookedTicketsByUser();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
