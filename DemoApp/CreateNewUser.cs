using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace DemoApp
{
    public partial class CreateNewUser : Form
    {
        EmployeeModel employeeModel;

        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void buttonCancelNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxlastName.Text;
            string email = textBoxEmail.Text;
            string location = comboBoxLocation.Text;
            string phoneNumber = textBoxPhone.Text;
            string UserRole = comboBoxUserType.Text;    

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(UserRole) || !sendPasswordBox.Checked)
            {
                MessageBox.Show("Please fill in all required fields.", "Error");
                return; 
            }

            EmployeeRole role;

            if (UserRole == "Employee")
            {
                role = EmployeeRole.Regular;
            }
            else
            {
                role = EmployeeRole.ServiceDesk;
            }

            int passwordAsInt = 1234;

            string passwordAsString = passwordAsInt.ToString();

            string hashedPassword = HashPassword(passwordAsString);

            var employeeData = new EmployeeModel
            {
                Username = firstName,
                Password = hashedPassword, 
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Location = location,
                PhoneNumber = phoneNumber,
                Role = role
            };

            var addEmployeeLogic = new AddEmployeeLogic();
            addEmployeeLogic.AddEmployee(employeeData);

            MessageBox.Show("Employee added successfully!", "Successful!");
            this.Close();
        }

        public string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
