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
        List<TicketModel> tickets;
        public IncidentManagementView(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
            ticketsLogic = new TicketsLogic();
            tickets = new List<TicketModel>();
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
            form = new CreateNewIncident(employee);
            form.Show();
            ShowTickets();
        }

        private void IncidentManagementView_Load(object sender, EventArgs e)
        {
            radioButtonHightoLow.CheckedChanged += (s, ev) => SortTicketsByPriority(Model.PriorityOrder.HighMediumLow);
            radioButtonLowToHigh.CheckedChanged += (s, ev) => SortTicketsByPriority(Model.PriorityOrder.LowMediumHigh);
            ShowTickets();
        }
        private List<TicketModel> GetTickets(List<TicketModel> tickets)
        {
            foreach (TicketModel ticket in tickets)
            {
                ListViewItem listViewItem = new ListViewItem(ticket.Subject);
                listViewItem.SubItems.Add(ticket.User.Username);
                listViewItem.SubItems.Add(ticket.dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                listViewItem.SubItems.Add(ticket.Status.ToString());
                listViewItem.SubItems.Add(ticket.Priority.ToString());
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

                        MessageBox.Show("Ticket updated successfully");
                        ShowTickets();
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("No item selected");
                }
            }
            catch
            {
                throw new Exception("Editing Tickets Failed");
            }
        }
        public void ShowTickets()
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem listViewItem in listViewTickets.SelectedItems)
                    {
                        string selectedTicketId = listViewItem.Tag.ToString();
                        ticketsLogic.DeleteTicket(selectedTicketId);
                    }
                    MessageBox.Show("Ticket Deleted Successfully");
                    ShowTickets();
                }
            }
            catch
            {
                new Exception("Deleting ticket failed");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShowTickets();
        }
        private void SortTicketsByPriority(PriorityOrder priorityOrder)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (ListViewItem item in listViewTickets.Items)
            {
                listViewItems.Add(item);
            }

            if (priorityOrder == PriorityOrder.HighMediumLow)
            {
                listViewItems = listViewItems.OrderBy(item => (Priority)Enum.Parse(typeof(Priority), item.SubItems[4].Text)).ToList();
            }
            else
            {
                listViewItems = listViewItems.OrderByDescending(item => (Priority)Enum.Parse(typeof(Priority), item.SubItems[4].Text)).ToList();
            }

            listViewTickets.Items.Clear();

            listViewTickets.Items.AddRange(listViewItems.ToArray());
        }

        private void buttonResolve_Click(object sender, EventArgs e)
        {
            UpdateTicketStatus(TicketStatus.Resolved);

        }
        private void buttonCloseWithoutResolve_Click(object sender, EventArgs e)
        {
            UpdateTicketStatus(TicketStatus.ClosedWithoutResolve);

        }
        private void EnableButtonsBasedOnStatus(TicketStatus status)
        {
            buttonResolve.Enabled = (status == TicketStatus.Open);
            buttonCloseWithoutResolve.Enabled = (status == TicketStatus.Open);
        }

        private void UpdateTicketStatus(TicketStatus newStatus)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedTicket = listViewTickets.SelectedItems[0];
                string selectedTicketId = selectedTicket.Tag.ToString();

                selectedTicket.SubItems[3].Text = newStatus.ToString(); 

                ticketsLogic.EditTicket(selectedTicketId, selectedTicket.SubItems[0].Text, employee, DateTime.Parse(selectedTicket.SubItems[2].Text), newStatus);

                MessageBox.Show($"Ticket status updated to {newStatus}", "Status Change");
                EnableButtonsBasedOnStatus(newStatus);
            }
        }
        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedTicket = listViewTickets.SelectedItems[0];
                TicketStatus status = (TicketStatus)Enum.Parse(typeof(TicketStatus), selectedTicket.SubItems[3].Text); // Assuming status is in the fourth column

                EnableButtonsBasedOnStatus(status);
            }
        }

        // still work on this
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateNewUser createNewUser = new CreateNewUser();
            createNewUser.Show();
        }
    }
}
