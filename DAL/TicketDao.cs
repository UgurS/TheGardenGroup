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
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(ticketId));
                var collectionName = "tickets";
                _baseDao.Delete(collectionName, filter);
            }
            catch
            {
                throw new Exception("An error occured while deleting the ticket from database.");
            }
        }

    }
}
