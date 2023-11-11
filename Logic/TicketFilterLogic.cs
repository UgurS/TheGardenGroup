using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class TicketFilterLogic
    {
        public void FilterListView(ListView listView, TextBox filterTextBox)
        {
            string filterText = filterTextBox.Text.ToLower();

            List<ListViewItem> matchingItems = new List<ListViewItem>();

            foreach (ListViewItem item in listView.Items)
            {
                bool itemMatchesFilter = item.SubItems.Cast<ListViewItem.ListViewSubItem>()
                    .Any(subItem => subItem.Text.ToLower().Contains(filterText));

                if (itemMatchesFilter)
                {
                    matchingItems.Add(item);
                }
            }

            listView.Items.Clear();

            listView.Items.AddRange(matchingItems.ToArray());
        }
    }
}
