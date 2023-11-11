using DAL;
using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class UserManagementView : Form
    {
        private EmployeeLogic employeeLogic;
        private EmployeeModel employee;
        private List<EmployeeModel> loadedEmployees;

        public UserManagementView(EmployeeLogic employeeLogic, EmployeeModel employee)
        {
            InitializeComponent();
            this.employeeLogic = employeeLogic;
            this.employee = employee;
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadEmployeesWithTicketCount();
        }

        private void LoadEmployeesWithTicketCount()
        {
            if (employeeLogic != null)
            {
                loadedEmployees = employeeLogic.GetAllEmployeesWithTicketCount();
                SortAndRefresh();
            }
            else
            {
                MessageBox.Show("EmployeeLogic is not initialized.", "Error");
            }
        }

        private void SortAndRefresh()
        {
            SortUsers();
            UpdateListView();
        }

        private void SortUsers()
        {
            if (radiobuttonFirstName.Checked)
            {
                loadedEmployees = loadedEmployees.OrderBy(employee => employee.FirstName).ToList();
            }
            else if (radiobuttonLastName.Checked)
            {
                loadedEmployees = loadedEmployees.OrderBy(employee => employee.LastName).ToList();
            }
            else if (radiobuttonTicketHigh.Checked)
            {
                loadedEmployees = loadedEmployees.OrderByDescending(employee => employee.TicketsCount).ToList();
            }
            else if (radiobuttonTicketLow.Checked)
            {
                loadedEmployees = loadedEmployees.OrderBy(employee => employee.TicketsCount).ToList();
            }
        }

        private void UpdateListView()
        {
            listViewUsers.Items.Clear();

            foreach (var employee in loadedEmployees)
            {
                ListViewItem item = new ListViewItem(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.TicketsCount.ToString());

                listViewUsers.Items.Add(item);
            }
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            IncidentManagementView incidentManagementView = new IncidentManagementView(employee);
            incidentManagementView.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            CreateNewUser createNewUser = new CreateNewUser();
            createNewUser.UserManagementView = this;
            createNewUser.Show();
        }

        public void AddUserToListView(EmployeeModel newEmployee)
        {
            loadedEmployees.Add(newEmployee);
            SortAndRefresh();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Dashboard serviceDeskDashboard = new Dashboard(employee);
            serviceDeskDashboard.Show();
        }

        private void radiobuttonFirstName_CheckedChanged(object sender, EventArgs e)
        {
            SortAndRefresh();
        }

        private void radiobuttonTicketHigh_CheckedChanged(object sender, EventArgs e)
        {
            SortAndRefresh();
        }

        private void radioButtonLastName_CheckedChanged(object sender, EventArgs e)
        {
            SortAndRefresh();
        }

        private void radiobuttonTicketLow_CheckedChanged(object sender, EventArgs e)
        {
            SortAndRefresh();
        }
    }
}
