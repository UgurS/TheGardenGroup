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
    public partial class RegularDashboard : Form
    {
        EmployeeModel employee;
        public RegularDashboard(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void RegularDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnNewIncident_Click(object sender, EventArgs e)
        {
            CreateNewIncident createNewIncident = new CreateNewIncident(employee);
            createNewIncident.Show();
        }
    }
}
