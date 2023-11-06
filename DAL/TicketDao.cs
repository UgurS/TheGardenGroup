using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDao
    {
        private BaseDao _baseDao = new BaseDao();
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
    }
}
