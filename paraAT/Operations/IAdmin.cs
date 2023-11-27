using AT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Operations
{
    interface IAdmin
    {
        int AddTicket(ETicket eTicket);
        int UpdateTicket(ETicket eTicket);
        int RemoveTicket(ETicket eTicket);
        DataTable ViewAllBookedTickets();
    }
}
