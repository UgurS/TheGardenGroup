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
    }
}
