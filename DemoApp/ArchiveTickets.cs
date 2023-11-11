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
    public partial class ArchiveTickets : Form
    {
        ArchiveTicketsLogic archiveTickets;
        List<TicketModel> tickets;

        public ArchiveTickets(List<TicketModel> tickets)
        {
            InitializeComponent();
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>
            {
                new ComboBoxItem { DisplayText = "1 month", Value = 30 },
                new ComboBoxItem { DisplayText = "6 months", Value = 180 },
                new ComboBoxItem { DisplayText = "1 year", Value = 360 },
                new ComboBoxItem { DisplayText = "2 years", Value = 720 }
             };

            comboBoxTicketAge.DataSource = comboBoxItems;
            comboBoxTicketAge.DisplayMember = "DisplayText";
            comboBoxTicketAge.ValueMember = "Value";

            this.tickets = tickets;

            archiveTickets = new ArchiveTicketsLogic();
            archiveTickets.ArchiveCompleted += ArchiveCompletedHandler;
        }

        private void ArchiveCompletedHandler(string text)
        {
            MessageBox.Show(text, "Ticket Management");
            this.Close();
        }


        private void buttonArchive_Click(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)comboBoxTicketAge.SelectedItem;

            if (selectedItem != null)
            {
                Console.WriteLine(selectedItem.Value);
                archiveTickets.Archive(tickets, selectedItem.Value);
            }
        }
    }
}
