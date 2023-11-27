
namespace AirwayTicketingApplication
{
    partial class AdminViewBookedTicketsForm
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
            this.lblAllBookedTickets = new System.Windows.Forms.Label();
            this.dgvBookedTickets = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookedTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllBookedTickets
            // 
            this.lblAllBookedTickets.AutoSize = true;
            this.lblAllBookedTickets.BackColor = System.Drawing.Color.White;
            this.lblAllBookedTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllBookedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBookedTickets.Location = new System.Drawing.Point(452, 21);
            this.lblAllBookedTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllBookedTickets.Name = "lblAllBookedTickets";
            this.lblAllBookedTickets.Size = new System.Drawing.Size(194, 27);
            this.lblAllBookedTickets.TabIndex = 35;
            this.lblAllBookedTickets.Text = "All Booked Tickets";
            // 
            // dgvBookedTickets
            // 
            this.dgvBookedTickets.AllowUserToAddRows = false;
            this.dgvBookedTickets.AllowUserToDeleteRows = false;
            this.dgvBookedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookedTickets.Location = new System.Drawing.Point(27, 64);
            this.dgvBookedTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBookedTickets.Name = "dgvBookedTickets";
            this.dgvBookedTickets.ReadOnly = true;
            this.dgvBookedTickets.RowHeadersWidth = 51;
            this.dgvBookedTickets.Size = new System.Drawing.Size(1013, 439);
            this.dgvBookedTickets.TabIndex = 33;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(27, 511);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // AdminViewBookedTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAllBookedTickets);
            this.Controls.Add(this.dgvBookedTickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminViewBookedTicketsForm";
            this.ShowIcon = false;
            this.Text = "View Booked Tickets (Admin)";
            this.Load += new System.EventHandler(this.AdminViewBookedTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookedTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllBookedTickets;
        private System.Windows.Forms.DataGridView dgvBookedTickets;
        private System.Windows.Forms.Button btnBack;
    }
}