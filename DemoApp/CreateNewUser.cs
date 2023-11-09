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
        private UserManagementView userManagementView;
        int passwordAsInt = 1234;

        public CreateNewUser()
        {
            InitializeComponent();
        }
        public UserManagementView UserManagementView
        {
            get { return userManagementView; }
            set { userManagementView = value; }
        }
        private void buttonCancelNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                EmployeeModel employeeData = CreateEmployeeModel();
                AddEmployeeToDatabase(employeeData);

                MessageBox.Show("Employee added successfully!", "Successful!");
                this.Close();

                userManagementView.AddUserToListView(employeeData);
            }
        }

        private bool ValidateUserInput()
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
                return false;
            }

            return true;
        }

        private EmployeeModel CreateEmployeeModel()
        {
            EmployeeRole role = (comboBoxUserType.Text == "Employee") ? EmployeeRole.Regular : EmployeeRole.ServiceDesk;

            string passwordAsString = passwordAsInt.ToString();
            string hashedPassword = HashPassword(passwordAsString);

            return new EmployeeModel
            {
                Username = textBoxFirstName.Text,
                Password = hashedPassword,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxlastName.Text,
                Email = textBoxEmail.Text,
                Location = comboBoxLocation.Text,
                Phone = textBoxPhone.Text,
                Role = role
            };
        }

        private void AddEmployeeToDatabase(EmployeeModel employeeData)
        {
            var addEmployeeLogic = new AddEmployeeLogic();
            addEmployeeLogic.AddEmployee(employeeData);
        }

        private string HashPassword(string password)
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
