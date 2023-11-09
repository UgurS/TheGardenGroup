using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
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

        public List<TicketModel> GetAllTickets(EmployeeModel employee)
        {
            if (employee.Role == EmployeeRole.Regular)
            {
                return ticketDao.GetAllTickets(employee);
            }

            return GetAllTickets();
        }

        public int CountTicketStatus(List<TicketModel> tickets, TicketStatus status)
        {
            int count = 0;

            foreach (var ticket in tickets)
            {
                if (ticket.Status == status)
                {
                    count++;
                }
            }

            return count;
        }

        public void EditTicket(string ticketId, string subject, EmployeeModel reportedBy, DateTime openDate, TicketStatus status)
        {

            if (!string.IsNullOrEmpty(subject) && reportedBy != null)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(ticketId));
                var update = Builders<BsonDocument>.Update
                    .Set("subject", subject)
                    .Set("reportedBy.username", reportedBy.Username)
                    .Set("openDate", openDate)
                    .Set("status", status);

                TicketDao ticketDao = new TicketDao();
                ticketDao.UpdateTicket("tickets", filter, update);
            }
        }
        public void DeleteTicket(string ticketId)
        {
            ticketDao.DeleteTicket(ticketId);
        }
    }
}
