using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeTicketCount
    {
        [BsonElement("EmployeeID")]
        public ObjectId EmployeeId { get; set; }

        [BsonElement("count")]
        public int Count { get; set; }

        public string Username { get; set; } 
    }
}
