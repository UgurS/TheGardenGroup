using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        [BsonId]
        public ObjectId TicketId { get; set; }

        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("ticketOpenDate")]
        public DateTime TicketOpenDate { get; set; }

        [BsonElement("ticketCloseDate")]
        public DateTime TicketCloseDate { get; set; }

        [BsonElement("ticketDescription")]
        public string TicketDescription { get; set; }

        [BsonElement("ticketStatus")]
        public TicketStatus TicketStatus { get; set; }

        [BsonElement("ticketSubject")]
        public string TicketSubject { get; set; }

        [BsonElement("incidentDuration")]
        public int IncidentDuration { get; set; }

        [BsonElement("ticketPriority")]
        public int TicketPriority { get; set; }
        
        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }

        [BsonElement("TypeOfIncident")]
        public IncidentType IncidentType { get; set; }



        public Ticket(ObjectId userId, DateTime ticketOpenDate, DateTime ticketCloseDate, 
            string ticketDescription, TicketStatus ticketStatus, string ticketSubject, 
            int incidentDuration, int ticketPriority, DateTime deadline, 
            IncidentType incidentType)
        {
            UserId = userId;
            TicketOpenDate = ticketOpenDate;
            TicketCloseDate = ticketCloseDate;
            TicketDescription = ticketDescription;
            TicketStatus = ticketStatus;
            TicketSubject = ticketSubject;
            IncidentDuration = incidentDuration;
            TicketPriority = ticketPriority;
            Deadline = deadline;
            IncidentType = incidentType;
        }
    }
}
