using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DemoApp
{
    public partial class IncidentManagementView : Form
    {
        Form form = new Form();
        EmployeeModel employee;
        TicketsLogic ticketsLogic;
        public IncidentManagementView(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
            ticketsLogic = new TicketsLogic();
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
          form = new CreateNewIncident(employee);
          form.Show();
        }

        private void IncidentManagementView_Load(object sender, EventArgs e)
        {
            ShowTickets();
        }
        private List <TicketModel> GetTickets(List<TicketModel> tickets)
        {
            foreach (TicketModel ticket in tickets)
            {
                ListViewItem listViewItem = new ListViewItem(ticket.Subject);
                listViewItem.SubItems.Add(ticket.User.Username);
                listViewItem.SubItems.Add(ticket.dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                listViewItem.SubItems.Add(ticket.Status.ToString());
                listViewItem.Tag = ticket.Id;
                listViewTickets.Items.Add(listViewItem);
            }
            return tickets;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count > 0)
                {

                    string selectedTicketId = listViewTickets.SelectedItems[0].Tag.ToString();
                    string updatedSubject = textBoxSubject.Text;
                    EmployeeModel updatedUser = new EmployeeModel { Username = textBoxUser.Text };
                    DateTime updatedDate = dateTimePicker.Value;
                    string updatedStatus = textBoxStatus.Text;
                    if (Enum.TryParse<TicketStatus>(updatedStatus, out TicketStatus status))
                    {
                        ticketsLogic.EditTicket(selectedTicketId, updatedSubject, updatedUser, updatedDate, status);

                        ShowTickets();
                        ClearTextBoxes();
                    }
                }
            }
            catch
            {
                throw new Exception("No item Selected");
            }
        }
        private void ShowTickets()
        {
            listViewTickets.Items.Clear();
            List<TicketModel> tickets = ticketsLogic.GetAllTickets();
            GetTickets(tickets);
        }
        private void ClearTextBoxes()
        {
            textBoxSubject.Clear();
            textBoxUser.Clear();
            textBoxStatus.Clear();
        }
    }
}
