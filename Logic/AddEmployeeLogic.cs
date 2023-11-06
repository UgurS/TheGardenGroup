using Model;
using DAL;
using System;

namespace Logic
{
    public class AddEmployeeLogic
    {
        private EmployeeDao employeeDao;

        public AddEmployeeLogic()
        {
            employeeDao = new EmployeeDao();
        }
            
        public void AddEmployee(EmployeeModel employee)
        {
            try
            {
                employeeDao.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add employee: " + ex.Message);
            }
        }
    }
}
