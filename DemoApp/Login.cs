﻿using DAL;
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
            try
            {
                LoginLogic loginLogic = new LoginLogic();
                EmployeeModel employee = loginLogic.Login(tbUsername.Text, tbPassword.Text);

                if (employee.Role == EmployeeRole.Regular)
                {
                    Dashboard dashboard = new Dashboard(employee);
                    dashboard.Show();
                }
                else if (employee.Role == EmployeeRole.ServiceDesk)
                {
                    //IncidentManagementView incidentManagementView = new IncidentManagementView(employee);
                    //incidentManagementView.Show();
                    Dashboard dashboard = new Dashboard(employee);
                    dashboard.Show();
                }

                this.Hide();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "The Garden Group");
            }       
        }
    }
}
