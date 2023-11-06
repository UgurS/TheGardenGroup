using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    internal class TicketsDAO:DAO
    {
        static IMongoCollection<Ticket> collection;

        public TicketsDAO()
        {
            database = client.GetDatabase("thegardengroup");
            collection = database.GetCollection<Ticket>("Tickets");
        }

        public void InsertTicket(Ticket ticket)
        {
            collection.InsertOne(ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return collection.AsQueryable().ToList();
        }

        public Ticket GetByDescription(string description)
        {
            List<Ticket> tickets = collection.AsQueryable().ToList<Ticket>();

            foreach (Ticket t in tickets)
            {
                if (t.TicketDescription == description)
                {
                    return t;
                }
            }
            return null;
        }

        public void UpdateTicketStatus(Ticket ticket, TicketStatus newStatus)
        {
            try
            {
                var collection = database.GetCollection<BsonDocument>("tickets");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.TicketId);
                var update = Builders<BsonDocument>.Update.Set("ticketStatus", (int)newStatus);

                collection.UpdateOne(filter, update);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while connecting to the database. Please try again later.");
            }
        }

        public void UpdateTicketInformation(Ticket ticket)
        {
            try
            {
                var collection = database.GetCollection<BsonDocument>("tickets");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.TicketId);

                var update = Builders<BsonDocument>.Update.Set("ticketSubject", ticket.TicketSubject)
                                                          .Set("ticketDescription", ticket.TicketDescription)
                                                          .Set("incidentDuration", ticket.IncidentDuration)
                                                          .Set("ticketPriority", ticket.TicketPriority)
                                                          .Set("deadline", ticket.Deadline);

                collection.UpdateOne(filter, update);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while connecting to the database. Please try again later.");
            }

        }

        //public List<Ticket> GetAllOpenTickets() // Getting everything as BsonDocument
        //{
        //    var collection = database.GetCollection<BsonDocument>("tickets");
        //    var filter = Builders<BsonDocument>.Filter.Eq("ticketStatus", 0);
        //    var documents = collection.Find(filter).ToList();

        //    List<Ticket> openTickets = new List<Ticket>();

        //    foreach (BsonDocument document in documents)
        //    {
        //        Ticket ticket = BsonSerializer.Deserialize<Ticket>(document); // Deserialize is a process of reverse object mapping.
        //        openTickets.Add(ticket);
        //    }
        //    return openTickets;
        //}

        //public void AddClosedTicketToArchiveCollection()
        //{
        //    List<Ticket> tickets = GetAllTickets();
        //    if (tickets == null)
        //    {
        //        throw new Exception("Something went wrong, try again");
        //    }
        //    foreach (Ticket ticket in tickets)
        //    {
        //        if (!IsTicketDateWithin2Years(ticket.TicketOpenDate))
        //        {
        //            GetArchiveCollection().InsertOne(ticket);
        //            DeleteTicketFromDatabase(ticket);
        //        }
        //    }
        //}

        //private bool IsTicketDateWithin2Years(DateTime ticketOpenDate)
        //{
        //    TimeSpan timeSpan = DateTime.Today - ticketOpenDate;
        //    if (timeSpan.Days >= 730)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //private IMongoDatabase GetArchiveDatabase() // Returns the archive database by opening the archive database
        //{
        //    var client = new MongoClient("mongodb+srv://vedatturk:1234@cluster0.kyqyr2q.mongodb.net/test");
        //    if (client == null)
        //    {
        //        throw new Exception("Something went wrong, try again");
        //    }
        //    return client.GetDatabase("Archive");
        //}

        // Returns the collection from Archive Database
        //private IMongoCollection<Ticket> GetArchiveCollection()
        //{
        //    IMongoCollection<Ticket> collectionArchive = GetArchiveDatabase().GetCollection<Ticket>("ArchiveTickets");
        //    return collectionArchive;
        //}

        public void UpdateTicketEmployee(Ticket ticket, ObjectId employeeId)
        {
            var collection = database.GetCollection<BsonDocument>("tickets");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.TicketId);
            var update = Builders<BsonDocument>.Update.Set("userId", employeeId);

            collection.UpdateOne(filter, update);
        }

        public void DeleteTicketFromDatabase(Ticket ticket)
        {
            var deleteFilter = Builders<Ticket>.Filter.Eq("_id", ticket.TicketId);
            collection.DeleteOne(deleteFilter);
        }
    }
}
