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
            LoginLogic loginLogic = new LoginLogic();
            Console.WriteLine(loginLogic.HashPassword(tbPassword.Text));

            EmployeeModel employee = loginLogic.Login(tbUsername.Text, tbPassword.Text);
            OpenNewView();
           /* Console.WriteLine(employee.email);*/
        }
        private void OpenNewView()
        {
            this.Hide();
            Form home = new Form();
            home = new IncidentManagementView();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }
    }
}
