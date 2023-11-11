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
    public class ArchiveTicketsLogic
    {
        public delegate void ArchiveCompletedCallback(string text);
        public event ArchiveCompletedCallback ArchiveCompleted;

        public void Archive(List<TicketModel> tickets, int days)
        {
            TicketDao ticketDao = new TicketDao();

            DateTime now = DateTime.Now;
            DateTime threshold = now.AddDays(-1 * days);
            Console.WriteLine(threshold);

            List<TicketModel> ticketsToArchive = tickets.Where(ticket => ticket.dateTime < threshold).ToList();
            List<BsonDocument> bsonDocuments = ticketsToArchive.Select(ticket => ticket.ToBsonDocument()).ToList();

            if (ticketsToArchive.Count > 0)
            {
                ticketDao.AddTicketsToArchive(bsonDocuments);
                ticketDao.DeleteTickets(ticketsToArchive);

                OnArchiveCompleted($"{ticketsToArchive.Count} tickets archived successfully.");
            } else
            {
                OnArchiveCompleted("There is no ticket older than the selected period.");
            }

        }

        protected virtual void OnArchiveCompleted(string text)
        {
            ArchiveCompleted?.Invoke(text);
        }
    }
}
