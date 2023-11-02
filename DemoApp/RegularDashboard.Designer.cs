namespace DemoApp
{
    partial class RegularDashboard
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
            this.btnNewIncident = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewIncident
            // 
            this.btnNewIncident.Location = new System.Drawing.Point(651, 12);
            this.btnNewIncident.Name = "btnNewIncident";
            this.btnNewIncident.Size = new System.Drawing.Size(137, 64);
            this.btnNewIncident.TabIndex = 0;
            this.btnNewIncident.Text = "Create New Incident";
            this.btnNewIncident.UseVisualStyleBackColor = true;
            this.btnNewIncident.Click += new System.EventHandler(this.btnNewIncident_Click);
            // 
            // RegularDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewIncident);
            this.Name = "RegularDashboard";
            this.Text = "RegularDashboard";
            this.Load += new System.EventHandler(this.RegularDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewIncident;
    }
}