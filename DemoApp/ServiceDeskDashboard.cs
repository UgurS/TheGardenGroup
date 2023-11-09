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
    public partial class ServiceDeskDashboard : Form
    {
        EmployeeModel employee;
        private EmployeeLogic employeeLogic;

        public ServiceDeskDashboard(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            IncidentManagementView incidentManagementView = new IncidentManagementView(employee);
            incidentManagementView.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            UserManagementView userManagementView = new UserManagementView(new EmployeeLogic(), employee);
            userManagementView.Show();
        }
    }
}
