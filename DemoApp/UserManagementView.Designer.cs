namespace DemoApp
{
    partial class UserManagementView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.radiobuttonFirstName = new System.Windows.Forms.RadioButton();
            this.radiobuttonTicketHigh = new System.Windows.Forms.RadioButton();
            this.radiobuttonLastName = new System.Windows.Forms.RadioButton();
            this.radiobuttonTicketLow = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Licensed To: The Garden Group";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 130);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 130);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEmail,
            this.columnFirstName,
            this.columnLastName,
            this.columnTickets});
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.LabelWrap = false;
            this.listViewUsers.Location = new System.Drawing.Point(9, 215);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(821, 522);
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 180;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 120;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.Width = 120;
            // 
            // columnTickets
            // 
            this.columnTickets.Text = "Number of Tickets";
            this.columnTickets.Width = 200;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddUser.Location = new System.Drawing.Point(818, 150);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(207, 60);
            this.buttonAddUser.TabIndex = 4;
            this.buttonAddUser.Text = "+ Add New User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // radiobuttonFirstName
            // 
            this.radiobuttonFirstName.AutoSize = true;
            this.radiobuttonFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radiobuttonFirstName.Location = new System.Drawing.Point(855, 260);
            this.radiobuttonFirstName.Name = "radiobuttonFirstName";
            this.radiobuttonFirstName.Size = new System.Drawing.Size(184, 26);
            this.radiobuttonFirstName.TabIndex = 5;
            this.radiobuttonFirstName.TabStop = true;
            this.radiobuttonFirstName.Text = "Sort by First Name";
            this.radiobuttonFirstName.UseVisualStyleBackColor = true;
            this.radiobuttonFirstName.CheckedChanged += new System.EventHandler(this.radiobuttonFirstName_CheckedChanged);
            // 
            // radiobuttonTicketHigh
            // 
            this.radiobuttonTicketHigh.AutoSize = true;
            this.radiobuttonTicketHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radiobuttonTicketHigh.Location = new System.Drawing.Point(855, 355);
            this.radiobuttonTicketHigh.Name = "radiobuttonTicketHigh";
            this.radiobuttonTicketHigh.Size = new System.Drawing.Size(178, 26);
            this.radiobuttonTicketHigh.TabIndex = 6;
            this.radiobuttonTicketHigh.TabStop = true;
            this.radiobuttonTicketHigh.Text = "Sort Tickets High ";
            this.radiobuttonTicketHigh.UseVisualStyleBackColor = true;
            this.radiobuttonTicketHigh.CheckedChanged += new System.EventHandler(this.radiobuttonTicketHigh_CheckedChanged);
            // 
            // radiobuttonLastName
            // 
            this.radiobuttonLastName.AutoSize = true;
            this.radiobuttonLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radiobuttonLastName.Location = new System.Drawing.Point(855, 307);
            this.radiobuttonLastName.Name = "radiobuttonLastName";
            this.radiobuttonLastName.Size = new System.Drawing.Size(183, 26);
            this.radiobuttonLastName.TabIndex = 7;
            this.radiobuttonLastName.TabStop = true;
            this.radiobuttonLastName.Text = "Sort by Last Name";
            this.radiobuttonLastName.UseVisualStyleBackColor = true;
            this.radiobuttonLastName.CheckedChanged += new System.EventHandler(this.radioButtonLastName_CheckedChanged);
            // 
            // radiobuttonTicketLow
            // 
            this.radiobuttonTicketLow.AutoSize = true;
            this.radiobuttonTicketLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radiobuttonTicketLow.Location = new System.Drawing.Point(855, 403);
            this.radiobuttonTicketLow.Name = "radiobuttonTicketLow";
            this.radiobuttonTicketLow.Size = new System.Drawing.Size(169, 26);
            this.radiobuttonTicketLow.TabIndex = 8;
            this.radiobuttonTicketLow.TabStop = true;
            this.radiobuttonTicketLow.Text = "Sort Tickets Low";
            this.radiobuttonTicketLow.UseVisualStyleBackColor = true;
            this.radiobuttonTicketLow.CheckedChanged += new System.EventHandler(this.radiobuttonTicketLow_CheckedChanged);
            // 
            // UserManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 833);
            this.Controls.Add(this.radiobuttonTicketLow);
            this.Controls.Add(this.radiobuttonLastName);
            this.Controls.Add(this.radiobuttonTicketHigh);
            this.Controls.Add(this.radiobuttonFirstName);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserManagementView";
            this.Text = "UserManagementView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnTickets;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.RadioButton radiobuttonFirstName;
        private System.Windows.Forms.RadioButton radiobuttonTicketHigh;
        private System.Windows.Forms.RadioButton radiobuttonLastName;
        private System.Windows.Forms.RadioButton radiobuttonTicketLow;
    }
}