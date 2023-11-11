using DAL;
using Logic;
using Model;
using MongoDB.Bson;
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
        private EmployeeLogic employeeLogic;
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
            HideServiceDeskControls();
        }

        private void HideServiceDeskControls()
        {
            if (employee.Role == EmployeeRole.Regular)
            {
                List<Control> serviceDeskControls = new List<Control>() {
                    btnArchive, buttonTransferTicket, buttonDelete, buttonUpdate, refreshButton, buttonResolve, buttonCloseWithoutResolve, labelSubject, textBoxSubject, labelPriority, textBoxPriority, dateTimePicker
                };

                foreach (var item in serviceDeskControls)
                {
                    item.Hide();
                }

                userManagementToolStripMenuItem.Visible = false;
            }
        }

        private void GetTickets(List<TicketModel> tickets)
        {
            foreach (TicketModel ticket in tickets)
            {
                ListViewItem listViewItem = new ListViewItem(ticket.Subject);
                listViewItem.SubItems.Add(ticket.User.Username);
                listViewItem.SubItems.Add(ticket.dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                listViewItem.SubItems.Add(ticket.Status.ToString());
                listViewItem.SubItems.Add(ticket.Priority.ToString());

                listViewItem.Tag = ticket;

                listViewTickets.Items.Add(listViewItem);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listViewTickets.SelectedItems[0];
                    TicketModel selectedTicket = (TicketModel)selectedItem.Tag;

                    string updatedSubject = textBoxSubject.Text;
                    string updatedPriority = textBoxPriority.Text;
                    DateTime updatedDate = dateTimePicker.Value;

                    if (Enum.TryParse<Priority>(updatedPriority, out Priority priority))
                    {
                        ticketsLogic.EditTicket(selectedTicket.Id, updatedSubject, priority, updatedDate);

                        MessageBox.Show("Ticket updated successfully");

                        ShowTickets();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Priority");
                    }
                }
                else
                {
                    MessageBox.Show("No item selected");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Editing Tickets Failed");
            }
        }

        public void ShowTickets()
        {
            listViewTickets.Items.Clear();
            tickets = ticketsLogic.GetAllTickets(employee);
            GetTickets(tickets);
        }
        private void ClearTextBoxes()
        {
            textBoxSubject.Clear();
            textBoxPriority.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem listViewItem in listViewTickets.SelectedItems)
                    {
                        if (listViewItem.Tag is TicketModel selectedTicketModel)
                        {
                            if (ObjectId.TryParse(selectedTicketModel.Id.ToString(), out _))
                            {
                                string selectedTicketId = selectedTicketModel.Id.ToString();
                                ticketsLogic.DeleteTicket(selectedTicketId);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid ObjectId: {selectedTicketModel.Id}", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Selected item is not a TicketModel. Tag type: {listViewItem.Tag?.GetType()}", "Error");
                        }
                    }
                    MessageBox.Show("Ticket Deleted Successfully");
                    ShowTickets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deleting ticket failed. Error: {ex.Message}");
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

                if (selectedTicket.Tag is TicketModel selectedTicketModel)
                {
                    string selectedTicketId = selectedTicketModel.Id.ToString();

                    selectedTicket.SubItems[3].Text = newStatus.ToString();

                    ticketsLogic.CloseTicket(selectedTicketId, newStatus);

                    MessageBox.Show($"Ticket status updated to {newStatus}", "Status Change");
                    EnableButtonsBasedOnStatus(newStatus);
                }
                else
                {
                    MessageBox.Show("Selected item is not a TicketModel", "Error");
                }
            }
        }


        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedListViewItem = listViewTickets.SelectedItems[0];

                if (selectedListViewItem.Tag is TicketModel selectedTicketModel)
                {
                    TicketStatus status = selectedTicketModel.Status;

                    buttonTransferTicket.Enabled = (status == TicketStatus.Open);

                    EnableButtonsBasedOnStatus(status);
                }
                else
                {
                    MessageBox.Show($"Selected item is not a TicketModel. Tag type: {selectedListViewItem.Tag?.GetType()}", "Error");
                }
            }
            else
            {
                buttonTransferTicket.Enabled = false;
            }
        }


        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            UserManagementView userManagementView = new UserManagementView(new EmployeeLogic(), employee);
            userManagementView.Show();
        }

        private void buttonTransferTicket_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                TicketModel selectedTicket = (TicketModel)listViewTickets.SelectedItems[0].Tag;
                TransferTicketView transferTicketView = new TransferTicketView(selectedTicket);
                transferTicketView.Show();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Hide();
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTickets();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ArchiveTickets archiveTickets = new ArchiveTickets(tickets);
            archiveTickets.Show();
        }
    }
}
