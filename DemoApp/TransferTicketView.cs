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
    public partial class TransferTicketView : Form
    {
        private TicketModel selectedTicket;
        private EmployeeLogic employeeLogic;
        private TicketsLogic ticketsLogic;

        public TransferTicketView(TicketModel ticket)
        {
            InitializeComponent();
            selectedTicket = ticket;

            employeeLogic = new EmployeeLogic();
            ticketsLogic = new TicketsLogic();

            InitializeForm();
        }

        private void InitializeForm()
        {
            PopulateTicketDetails();
            PopulateUserComboBox();
        }

        private void PopulateTicketDetails()
        {
            ListViewItem listViewItem = new ListViewItem(selectedTicket.Subject);
            listViewItem.SubItems.Add(selectedTicket.User.Username);
            listViewItem.SubItems.Add(selectedTicket.dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            listViewItem.SubItems.Add(selectedTicket.Status.ToString());
            listViewItem.SubItems.Add(selectedTicket.Priority.ToString());

            listViewItem.Tag = selectedTicket;
            listViewTicketsT.Items.Add(listViewItem);
        }

        private void PopulateUserComboBox()
        {
            List<EmployeeModel> users = employeeLogic.GetAllEmployees();
            comboBoxUsersList.DisplayMember = "Username";
            comboBoxUsersList.DataSource = users;
            comboBoxUsersList.SelectedItem = selectedTicket.User;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            EmployeeModel selectedUser = (EmployeeModel)comboBoxUsersList.SelectedItem;
            ticketsLogic.TransferTicket(selectedTicket, selectedUser);

            this.Close();
        }
    }
}