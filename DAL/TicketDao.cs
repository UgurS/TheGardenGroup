using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

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
        public List<TicketModel> GetAllTickets()
        {
            return collection1.Find(_ => true).ToList();
        }
        public void UpdateTicket(string collectionName, FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            try
            {
                _baseDao.Update(collectionName, filter, update);
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




    }
}
