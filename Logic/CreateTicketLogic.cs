using DAL;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CreateTicketLogic
    {
        public void Submit(DateTime dateTime, string subject, string type, EmployeeModel reportedBy, string priority, int deadlineIndex, string description)
        {
            if (dateTime != null && !String.IsNullOrEmpty(subject) && !String.IsNullOrEmpty(type) && !String.IsNullOrEmpty(priority) && !String.IsNullOrEmpty(description))
            {
                var document = new BsonDocument
                {
                    { "subject", subject },
                    { "incidentType", type },
                    { "reportedBy", 
                        new BsonDocument {
                            { "_id", reportedBy.Id },
                            { "username", reportedBy.Username }
                        } 
                    },
                    { "priority", priority },
                    { "deadline", GetDeadline(deadlineIndex) },
                    { "description", description },
                    { "openDate", DateTime.Now },
                    { "status", TicketStatus.Open },
                };

                TicketDao ticketDao = new TicketDao();
                ticketDao.AddTicket(document);
            }
        }

        public DateTime GetDeadline(int index)
        {
            switch (index) { 
                case 0:
                    return DateTime.Now.AddDays(7);
                case 1: 
                    return DateTime.Now.AddDays(14);
                case 2:
                    return DateTime.Now.AddDays(28);
                case 3:
                    return DateTime.Now.AddMonths(6);
                default:
                    return DateTime.Now.AddDays(7);
            }
        }
    }
}
