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
        CreateNewUser createNewUser = new CreateNewUser();
        public ServiceDeskDashboard(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            createNewUser.Show();
        }
    }
}
