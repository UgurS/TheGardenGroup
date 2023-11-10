using DAL;
using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmployeeLogic
    {
        private EmployeeDao employeeDao;
        private BaseDao baseDao;

        public EmployeeLogic()
        {
            employeeDao = new EmployeeDao();
            baseDao = new BaseDao(); // Add this line to initialize baseDao
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return employeeDao.GetAllEmployees();
        }

        public List<EmployeeModel> GetAllEmployeesWithTicketCount()
        {
            var employees = GetAllEmployees();

            foreach (var employee in employees)
            {
                int ticketCount = GetTicketCountForUser(employee.Username);
                employee.TicketsCount = ticketCount;
            }

            return employees;
        }

        public int GetTicketCountForUser(string username)
        {
            var filter = Builders<TicketModel>.Filter.Eq("reportedBy.username", username);
            var ticketCount = baseDao.collection1.CountDocuments(filter);

            return (int)ticketCount;
        }
    }
}
