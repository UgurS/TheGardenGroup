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
    public partial class CreateNewIncident : Form
    {
        EmployeeModel employee;
        public CreateNewIncident(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;

            dateTimeReported.MaxDate = DateTime.Now;
            dateTimeReported.CustomFormat = "dd/MM/yyyy - HH:mm";

            cbUser.Items.Clear();

            if (employee.Role == EmployeeRole.Regular) {
                cbUser.Items.Add(employee.Username);
                cbUser.SelectedIndex = 0;
                cbUser.Enabled = false; 
            }
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            try
            {
                CreateTicketLogic createTicket = new CreateTicketLogic();
                createTicket.Submit(dateTimeReported.Value, tbIncidentSubject.Text, cbIncidentType.Text, employee, cbPriority.Text, cbDeadline.SelectedIndex, rtbDescription.Text);
                MessageBox.Show("Ticket successfully submitted", "The Garden Group");
                this.Close();
            } catch
            {
                MessageBox.Show("We were unable to submit your ticket. Please check all fields and try again.", "The Garden Group");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
