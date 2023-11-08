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
        private EmployeeLogic employeeLogic;
        public CreateNewIncident(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
            employeeLogic = new EmployeeLogic();

            dateTimeReported.MaxDate = DateTime.Now;
            dateTimeReported.CustomFormat = "dd/MM/yyyy - HH:mm";
            cbPriority.Items.Add(Priority.Low.ToString());
            cbPriority.Items.Add(Priority.Medium.ToString());
            cbPriority.Items.Add(Priority.High.ToString());

            cbUser.Items.Clear();

            if (employee.Role == EmployeeRole.Regular)
            {
                cbUser.Items.Add(employee.Username);
                cbUser.SelectedIndex = 0;
                cbUser.Enabled = false;
            }
            else if (employee.Role == EmployeeRole.ServiceDesk)
            {
                cbUser.Items.Add("Select Employee");
                List<EmployeeModel> employees = employeeLogic.GetAllEmployees();
                foreach (var emp in employees)
                {
                    cbUser.Items.Add(emp.Username);
                }
                cbUser.SelectedIndex = 0;
                cbUser.Enabled = true;
            }
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            try
            {
                CreateTicketLogic createTicket = new CreateTicketLogic();
                if (employee.Role == EmployeeRole.Regular)
                {
                    createTicket.Submit(dateTimeReported.Value, tbIncidentSubject.Text, cbIncidentType.Text, employee, (Priority)Enum.Parse(typeof(Priority), cbPriority.Text), cbDeadline.SelectedIndex, rtbDescription.Text);
                }
                else if(employee.Role == EmployeeRole.ServiceDesk)
                {
                    string selectedUser = cbUser.SelectedItem as string;
                    if(selectedUser == "Select Employee")
                    {
                        MessageBox.Show("Please select a valid employee from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        List<EmployeeModel> employees = employeeLogic.GetAllEmployees();
                        EmployeeModel selectedEmployee = employees.FirstOrDefault(emp => emp.Username == selectedUser);

                        if (selectedEmployee != null)
                        {
                            createTicket.Submit(dateTimeReported.Value, tbIncidentSubject.Text, cbIncidentType.Text, selectedEmployee, (Priority)Enum.Parse(typeof(Priority), cbPriority.Text), cbDeadline.SelectedIndex, rtbDescription.Text);
                        }
                        else
                        {
                            MessageBox.Show("Selected User Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                MessageBox.Show("Ticket successfully submitted", "The Garden Group");
                this.Close();
            }
            catch
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
