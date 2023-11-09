using DAL;
using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginLogic loginLogic = new LoginLogic();
                EmployeeModel employee = loginLogic.Login(tbUsername.Text, tbPassword.Text);

                if (employee.Role == EmployeeRole.Regular)
                {
                    RegularDashboard regularDashboard = new RegularDashboard(employee);
                    regularDashboard.Show();
                }
                else if (employee.Role == EmployeeRole.ServiceDesk)
                {
                  ServiceDeskDashboard serviceDashboard = new ServiceDeskDashboard(employee);
                  serviceDashboard.Show();
                }

                this.Hide();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "The Garden Group");
            }       
        }
    }
}
