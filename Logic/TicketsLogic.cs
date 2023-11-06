using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketsLogic
    {
        TicketDao ticketDao;
        public TicketsLogic()
        {
            ticketDao = new TicketDao();
        }
        public List<TicketModel> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

    }
}
