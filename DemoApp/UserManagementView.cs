using DAL;
using Logic;
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

namespace DemoApp
{
    public partial class UserManagementView : Form
    {
        private EmployeeLogic employeeLogic;
        private EmployeeModel employee;
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
                List<EmployeeModel> employeesWithTicketCount = employeeLogic.GetAllEmployeesWithTicketCount();

                listViewUsers.Items.Clear();

                foreach (var employee in employeesWithTicketCount)
                {
                    ListViewItem item = new ListViewItem(employee.Email);
                    item.SubItems.Add(employee.FirstName);
                    item.SubItems.Add(employee.LastName);
                    item.SubItems.Add(employee.TicketsCount.ToString());

                    listViewUsers.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("EmployeeLogic is not initialized.", "Error");
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
        public void AddUserToListView(EmployeeModel employee)
        {
            ListViewItem item = new ListViewItem(employee.Email);
            item.SubItems.Add(employee.FirstName);
            item.SubItems.Add(employee.LastName);
            item.SubItems.Add(employee.TicketsCount.ToString());

            listViewUsers.Items.Add(item);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            ServiceDeskDashboard serviceDeskDashboard = new ServiceDeskDashboard(employee);
            serviceDeskDashboard.Show();
        }
    }
}
