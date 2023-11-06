using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TicketModel
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement ("openDate")]
        public DateTime dateTime { get; set; }

        [BsonElement("incidentType")]
        public string IncidentType { get; set; }
        [BsonElement("reportedBy")]
        public EmployeeModel User { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("role")]
        public EmployeeRole Role { get; set; }

        [BsonElement("priority")]
        public string Priority { get; set; }

        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("status")]
        public TicketStatus Status { get; set; }
    }
}
