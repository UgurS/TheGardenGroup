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
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoApp
{
    public partial class Dashboard : Form
    {
        EmployeeModel employee;
        public Dashboard(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnNewIncident_Click(object sender, EventArgs e)
        {
            CreateNewIncident createNewIncident = new CreateNewIncident(employee);
            createNewIncident.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TicketsLogic ticket = new TicketsLogic();
            List<TicketModel> tickets = ticket.GetAllTickets(employee);
            int unresolved = ticket.CountTicketStatus(tickets, TicketStatus.Open);
            int resolved = ticket.CountTicketStatus(tickets, TicketStatus.Resolved);
            int pastDeadline = ticket.CountTicketStatus(tickets, TicketStatus.ClosedWithoutResolve);

            chartUnresolvedIncidents.Series["Series1"].Points.AddXY("Unresolved", unresolved);
            chartUnresolvedIncidents.Series["Series1"].Points.AddXY("Resolved", resolved);
            chartUnresolvedIncidents.Series["Series1"].Points.AddXY("Past Deadline", pastDeadline);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            IncidentManagementView incidentManagementView = new IncidentManagementView(employee);
            incidentManagementView.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Hide();
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidentManagementView incidentManagementView = new IncidentManagementView(employee);
            incidentManagementView.Show();
            this.Hide();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementView userManagementView = new UserManagementView(new EmployeeLogic(), employee);
            userManagementView.Show();
            this.Hide();
        }
    }
}
