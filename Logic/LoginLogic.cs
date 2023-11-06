using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoginLogic
    {
        public string HashPassword(string password) 
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public EmployeeModel Login(string username, string password)
        {
            EmployeeDao dao = new EmployeeDao();

            string hashedPassword = HashPassword(password);

            return dao.GetEmployeeByAuth(username, hashedPassword);
        }
    }
}
