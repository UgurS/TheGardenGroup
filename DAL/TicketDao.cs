using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace DAL
{
    public class TicketDao:BaseDao
    {
        private BaseDao _baseDao = new BaseDao();
        public TicketDao() : base()
        {
            collection1 = _database.GetCollection<TicketModel>("tickets");
        }
        public void AddTicket(BsonDocument document)
        {
            try
            {
                _baseDao.Insert("tickets", document);
            }
            catch
            {
                throw new Exception("Missing or invalid input");
            }
        }

        public void AddTicketsToArchive(List<BsonDocument> documents)
        {
            try
            {
                _baseDao.InsertMany("archive", documents);
            }
            catch
            {
                throw new Exception("Missing or invalid input");
            }
        }

        public List<TicketModel> GetAllTickets()
        {
            var tickets = collection1.Find(_ => true).ToList();

            DateTime currentDateTime = DateTime.Now;

            foreach (var ticket in tickets)
            {
                if (ticket.Deadline < currentDateTime && ticket.Status == TicketStatus.Open)
                {
                    ticket.Status = TicketStatus.ClosedWithoutResolve;
                }
            }

            return tickets;
        }
        public List<TicketModel> GetAllTickets(EmployeeModel employee)
        {
            try
            {
                var filter = new BsonDocument
                {
                    { "reportedBy._id", employee.Id }
                };

                var result = _baseDao.Read("tickets", filter);
                var tickets = result.Select(document => BsonSerializer.Deserialize<TicketModel>(document)).ToList();

                DateTime currentDateTime = DateTime.Now;

                foreach (var ticket in tickets)
                {
                    if (ticket.Deadline < currentDateTime && ticket.Status == TicketStatus.Open)
                    {
                        ticket.Status = TicketStatus.ClosedWithoutResolve;
                    }
                }

                return tickets;
            }
            catch
            {
                throw new Exception("Missing or invalid input");
            }
        }

        public void UpdateTicket<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> update)
        {
            try
            {
                var collection = _database.GetCollection<T>(collectionName);
                collection.UpdateOne(filter, update);
            }
            catch
            {
                throw new Exception("Invalid Input");
            }
        }


        public void DeleteTicket(string ticketId)
        {
            try
            {
                // Verify if ticketId is a valid ObjectId
                if (!ObjectId.TryParse(ticketId, out var objectId))
                {
                    Console.WriteLine($"Invalid ObjectId: {ticketId}");
                    throw new ArgumentException("Invalid ObjectId", nameof(ticketId));
                }

                var filter = Builders<BsonDocument>.Filter.Eq("_id", objectId);
                var collectionName = "tickets";
                _baseDao.Delete(collectionName, filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the ticket from the database: {ex.Message}");
                throw new Exception($"An error occurred while deleting the ticket from the database. Details: {ex.Message}", ex);
            }
        }

        public void DeleteTickets(List<TicketModel> ticketsToDelete)
        {
            try
            {
                var ticketIdsToDelete = ticketsToDelete.Select(ticket => ticket.Id).ToList();
                var filter = Builders<TicketModel>.Filter.In("_id", ticketIdsToDelete);
                _baseDao.DeleteMany("tickets", filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the ticket from the database: {ex.Message}");
                throw new Exception($"An error occurred while deleting the ticket from the database. Details: {ex.Message}", ex);
            }
        }
    }
}
