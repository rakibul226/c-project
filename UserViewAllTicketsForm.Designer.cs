
namespace AirwayTicketingApplication
{
    partial class UserViewAllTicketsForm
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
            this.lblAllTickets = new System.Windows.Forms.Label();
            this.dgvAllTickets = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllTickets
            // 
            this.lblAllTickets.AutoSize = true;
            this.lblAllTickets.BackColor = System.Drawing.Color.White;
            this.lblAllTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTickets.Location = new System.Drawing.Point(484, 21);
            this.lblAllTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllTickets.Name = "lblAllTickets";
            this.lblAllTickets.Size = new System.Drawing.Size(115, 27);
            this.lblAllTickets.TabIndex = 33;
            this.lblAllTickets.Text = "All Tickets";
            // 
            // dgvAllTickets
            // 
            this.dgvAllTickets.AllowUserToAddRows = false;
            this.dgvAllTickets.AllowUserToDeleteRows = false;
            this.dgvAllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTickets.Location = new System.Drawing.Point(27, 65);
            this.dgvAllTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAllTickets.Name = "dgvAllTickets";
            this.dgvAllTickets.ReadOnly = true;
            this.dgvAllTickets.RowHeadersWidth = 51;
            this.dgvAllTickets.Size = new System.Drawing.Size(1013, 438);
            this.dgvAllTickets.TabIndex = 31;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(27, 511);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // UserViewAllTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAllTickets);
            this.Controls.Add(this.dgvAllTickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserViewAllTicketsForm";
            this.ShowIcon = false;
            this.Text = "View All Tickets (User)";
            this.Load += new System.EventHandler(this.UserViewAllTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllTickets;
        private System.Windows.Forms.DataGridView dgvAllTickets;
        private System.Windows.Forms.Button btnBack;
    }
}