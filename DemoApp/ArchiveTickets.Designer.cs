﻿namespace DemoApp
{
    partial class ArchiveTickets
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
            this.comboBoxTicketAge = new System.Windows.Forms.ComboBox();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archive all tickets older than";
            // 
            // comboBoxTicketAge
            // 
            this.comboBoxTicketAge.FormattingEnabled = true;
            this.comboBoxTicketAge.Location = new System.Drawing.Point(322, 48);
            this.comboBoxTicketAge.Name = "comboBoxTicketAge";
            this.comboBoxTicketAge.Size = new System.Drawing.Size(158, 28);
            this.comboBoxTicketAge.TabIndex = 1;
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(322, 108);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(158, 40);
            this.buttonArchive.TabIndex = 2;
            this.buttonArchive.Text = "Archive Tickets";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // ArchiveTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 203);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.comboBoxTicketAge);
            this.Controls.Add(this.label1);
            this.Name = "ArchiveTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTicketAge;
        private System.Windows.Forms.Button buttonArchive;
    }
}