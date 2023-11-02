namespace DemoApp
{
    partial class CreateNewIncident
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
            this.dateTimeReported = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIncidentSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIncidentType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDeadline = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new incident ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date/time reported:";
            // 
            // dateTimeReported
            // 
            this.dateTimeReported.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeReported.Location = new System.Drawing.Point(226, 80);
            this.dateTimeReported.Name = "dateTimeReported";
            this.dateTimeReported.Size = new System.Drawing.Size(329, 26);
            this.dateTimeReported.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject of incident:";
            // 
            // tbIncidentSubject
            // 
            this.tbIncidentSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIncidentSubject.Location = new System.Drawing.Point(226, 120);
            this.tbIncidentSubject.Name = "tbIncidentSubject";
            this.tbIncidentSubject.Size = new System.Drawing.Size(329, 26);
            this.tbIncidentSubject.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type of incident:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 6;
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIncidentType.FormattingEnabled = true;
            this.cbIncidentType.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.cbIncidentType.Location = new System.Drawing.Point(226, 161);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(329, 28);
            this.cbIncidentType.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Reported by user:";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(226, 210);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(329, 28);
            this.cbUser.TabIndex = 10;
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbPriority.Location = new System.Drawing.Point(226, 250);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(329, 28);
            this.cbPriority.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Priority:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Deadline/follow up:";
            // 
            // cbDeadline
            // 
            this.cbDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.cbDeadline.Location = new System.Drawing.Point(226, 290);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(329, 28);
            this.cbDeadline.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(226, 341);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(329, 112);
            this.rtbDescription.TabIndex = 16;
            this.rtbDescription.Text = "";
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.Location = new System.Drawing.Point(402, 463);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(153, 50);
            this.btnSubmitTicket.TabIndex = 17;
            this.btnSubmitTicket.Text = "Submit Ticket";
            this.btnSubmitTicket.UseVisualStyleBackColor = true;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 50);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateNewIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitTicket);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbDeadline);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbIncidentType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIncidentSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeReported);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewIncident";
            this.Text = "Create New Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeReported;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIncidentSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIncidentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDeadline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Button btnCancel;
    }
}