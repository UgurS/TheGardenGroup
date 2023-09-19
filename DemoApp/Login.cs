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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginLogic loginLogic = new LoginLogic();
            Console.WriteLine(loginLogic.HashPassword(tbPassword.Text));

            EmployeeModel employee = loginLogic.Login(tbUsername.Text, tbPassword.Text);
           /* Console.WriteLine(employee.email);*/
        }
    }
}
