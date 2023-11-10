namespace DemoApp
{
    partial class TransferTicketView
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
            this.listViewTicketsT = new System.Windows.Forms.ListView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxUsersList = new System.Windows.Forms.ComboBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 130);
            this.panel1.TabIndex = 1;
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
            // listViewTicketsT
            // 
            this.listViewTicketsT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnUser,
            this.columnDate,
            this.columnStatus,
            this.columnPriority});
            this.listViewTicketsT.HideSelection = false;
            this.listViewTicketsT.Location = new System.Drawing.Point(27, 161);
            this.listViewTicketsT.Name = "listViewTicketsT";
            this.listViewTicketsT.Size = new System.Drawing.Size(958, 168);
            this.listViewTicketsT.TabIndex = 2;
            this.listViewTicketsT.UseCompatibleStateImageBehavior = false;
            this.listViewTicketsT.View = System.Windows.Forms.View.Details;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCancel.Location = new System.Drawing.Point(745, 359);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(185, 52);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxUsersList
            // 
            this.comboBoxUsersList.FormattingEnabled = true;
            this.comboBoxUsersList.Location = new System.Drawing.Point(114, 373);
            this.comboBoxUsersList.Name = "comboBoxUsersList";
            this.comboBoxUsersList.Size = new System.Drawing.Size(323, 28);
            this.comboBoxUsersList.TabIndex = 5;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonTransfer.Location = new System.Drawing.Point(514, 359);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(185, 52);
            this.buttonTransfer.TabIndex = 6;
            this.buttonTransfer.Text = "Transfer Ticket";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Subject";
            this.columnSubject.Width = 120;
            // 
            // columnUser
            // 
            this.columnUser.Text = "User";
            this.columnUser.Width = 80;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 150;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 100;
            // 
            // columnPriority
            // 
            this.columnPriority.Text = "Priority";
            this.columnPriority.Width = 100;
            // 
            // TransferTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 479);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.comboBoxUsersList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listViewTicketsT);
            this.Controls.Add(this.panel1);
            this.Name = "TransferTicketView";
            this.Text = "TransferTicketView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTicketsT;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxUsersList;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnPriority;
    }
}