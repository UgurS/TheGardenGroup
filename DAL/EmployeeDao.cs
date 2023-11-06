using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDao
    {
        private BaseDao _baseDao = new BaseDao();
        public EmployeeModel GetEmployeeByAuth(string username, string hashedPassword)
        {
            try
            {
                var filter = new BsonDocument
                {
                    { "username", username },
                    { "password", hashedPassword }
                };

                var result = _baseDao.Read("employees", filter);
                return BsonSerializer.Deserialize<EmployeeModel>(result[0]);
            } catch
            {
                throw new Exception("Invalid username or password");
            }
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            try
            {
                var result = _baseDao.Read("employees", new BsonDocument());
                return result.Select(document => BsonSerializer.Deserialize<EmployeeModel>(document)).ToList();
            }
            catch
            {
                throw new Exception("Couldn't get employees.");
            }
        }
    }
}
