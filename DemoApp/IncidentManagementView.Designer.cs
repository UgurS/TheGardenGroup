namespace DemoApp
{
    partial class IncidentManagementView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createTicketButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.radioButtonHightoLow = new System.Windows.Forms.RadioButton();
            this.radioButtonLowToHigh = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonResolve = new System.Windows.Forms.Button();
            this.buttonCloseWithoutResolve = new System.Windows.Forms.Button();
            this.buttonTransferTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 162);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Licensed To: The Garden Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subject,
            this.User,
            this.Date,
            this.Status,
            this.Priority});
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(12, 292);
            this.listViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(1152, 565);
            this.listViewTickets.TabIndex = 2;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            this.listViewTickets.SelectedIndexChanged += new System.EventHandler(this.listViewTickets_SelectedIndexChanged);
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 157;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 101;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 153;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 111;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 90;
            // 
            // createTicketButton
            // 
            this.createTicketButton.Location = new System.Drawing.Point(1188, 444);
            this.createTicketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTicketButton.Name = "createTicketButton";
            this.createTicketButton.Size = new System.Drawing.Size(179, 58);
            this.createTicketButton.TabIndex = 3;
            this.createTicketButton.Text = "Create Incident";
            this.createTicketButton.UseVisualStyleBackColor = true;
            this.createTicketButton.Click += new System.EventHandler(this.createTicketButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1188, 531);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 58);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1188, 619);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(179, 58);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 162);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1397, 52);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(149, 48);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(270, 48);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 48);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 910);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(248, 31);
            this.textBoxSubject.TabIndex = 7;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(349, 910);
            this.textBoxPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(248, 31);
            this.textBoxPriority.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 980);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(416, 31);
            this.dateTimePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 871);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 871);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Priority";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1188, 706);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(179, 58);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // radioButtonHightoLow
            // 
            this.radioButtonHightoLow.AutoSize = true;
            this.radioButtonHightoLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHightoLow.Location = new System.Drawing.Point(1185, 292);
            this.radioButtonHightoLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHightoLow.Name = "radioButtonHightoLow";
            this.radioButtonHightoLow.Size = new System.Drawing.Size(182, 33);
            this.radioButtonHightoLow.TabIndex = 15;
            this.radioButtonHightoLow.TabStop = true;
            this.radioButtonHightoLow.Text = "High to Low";
            this.radioButtonHightoLow.UseVisualStyleBackColor = true;
            this.radioButtonHightoLow.CheckedChanged += new System.EventHandler(this.IncidentManagementView_Load);
            // 
            // radioButtonLowToHigh
            // 
            this.radioButtonLowToHigh.AutoSize = true;
            this.radioButtonLowToHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLowToHigh.Location = new System.Drawing.Point(1185, 350);
            this.radioButtonLowToHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonLowToHigh.Name = "radioButtonLowToHigh";
            this.radioButtonLowToHigh.Size = new System.Drawing.Size(182, 33);
            this.radioButtonLowToHigh.TabIndex = 16;
            this.radioButtonLowToHigh.TabStop = true;
            this.radioButtonLowToHigh.Text = "Low to High";
            this.radioButtonLowToHigh.UseVisualStyleBackColor = true;
            this.radioButtonLowToHigh.CheckedChanged += new System.EventHandler(this.IncidentManagementView_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1100, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sort Tickets by Priority";
            // 
            // buttonResolve
            // 
            this.buttonResolve.Enabled = false;
            this.buttonResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonResolve.Location = new System.Drawing.Point(1188, 828);
            this.buttonResolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResolve.Name = "buttonResolve";
            this.buttonResolve.Size = new System.Drawing.Size(179, 62);
            this.buttonResolve.TabIndex = 19;
            this.buttonResolve.Text = "Resolve";
            this.buttonResolve.UseVisualStyleBackColor = true;
            this.buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            // 
            // buttonCloseWithoutResolve
            // 
            this.buttonCloseWithoutResolve.Enabled = false;
            this.buttonCloseWithoutResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCloseWithoutResolve.Location = new System.Drawing.Point(1185, 910);
            this.buttonCloseWithoutResolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCloseWithoutResolve.Name = "buttonCloseWithoutResolve";
            this.buttonCloseWithoutResolve.Size = new System.Drawing.Size(179, 76);
            this.buttonCloseWithoutResolve.TabIndex = 20;
            this.buttonCloseWithoutResolve.Text = "Close without Resolve";
            this.buttonCloseWithoutResolve.UseVisualStyleBackColor = true;
            this.buttonCloseWithoutResolve.Click += new System.EventHandler(this.buttonCloseWithoutResolve_Click);
            // 
            // buttonTransferTicket
            // 
            this.buttonTransferTicket.Enabled = false;
            this.buttonTransferTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonTransferTicket.Location = new System.Drawing.Point(807, 231);
            this.buttonTransferTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransferTicket.Name = "buttonTransferTicket";
            this.buttonTransferTicket.Size = new System.Drawing.Size(259, 52);
            this.buttonTransferTicket.TabIndex = 21;
            this.buttonTransferTicket.Text = "Transfer Ticket";
            this.buttonTransferTicket.UseVisualStyleBackColor = true;
            this.buttonTransferTicket.Click += new System.EventHandler(this.buttonTransferTicket_Click);
            // 
            // IncidentManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1399, 1041);
            this.Controls.Add(this.buttonTransferTicket);
            this.Controls.Add(this.buttonCloseWithoutResolve);
            this.Controls.Add(this.buttonResolve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonLowToHigh);
            this.Controls.Add(this.radioButtonHightoLow);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.createTicketButton);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "IncidentManagementView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncidentManagementView";
            this.Load += new System.EventHandler(this.IncidentManagementView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.Button createTicketButton;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.RadioButton radioButtonHightoLow;
        private System.Windows.Forms.RadioButton radioButtonLowToHigh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonResolve;
        private System.Windows.Forms.Button buttonCloseWithoutResolve;
        private System.Windows.Forms.Button buttonTransferTicket;
    }
}