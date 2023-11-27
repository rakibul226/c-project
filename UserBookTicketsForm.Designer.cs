
namespace AirwayTicketingApplication
{
    partial class UserBookTicketsForm
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblEnterFlightNo = new System.Windows.Forms.Label();
            this.dgvAvailableTickets = new System.Windows.Forms.DataGridView();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.lblFlightTo = new System.Windows.Forms.Label();
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cox Bazar",
            "Dhaka",
            "Jessore",
            "Rajshahi",
            "Saidpur",
            "Sylhet"});
            this.cbFrom.Location = new System.Drawing.Point(680, 26);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(297, 28);
            this.cbFrom.Sorted = true;
            this.cbFrom.TabIndex = 26;
            // 
            // cbTo
            // 
            this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cox Bazar",
            "Dhaka",
            "Jessore",
            "Rajshahi",
            "Saidpur",
            "Sylhet"});
            this.cbTo.Location = new System.Drawing.Point(680, 63);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(297, 28);
            this.cbTo.Sorted = true;
            this.cbTo.TabIndex = 27;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTicket.Location = new System.Drawing.Point(680, 473);
            this.btnBookTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(123, 28);
            this.btnBookTicket.TabIndex = 31;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNo.Location = new System.Drawing.Point(680, 437);
            this.txtFlightNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(231, 26);
            this.txtFlightNo.TabIndex = 30;
            // 
            // lblEnterFlightNo
            // 
            this.lblEnterFlightNo.AutoSize = true;
            this.lblEnterFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFlightNo.Location = new System.Drawing.Point(303, 441);
            this.lblEnterFlightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterFlightNo.Name = "lblEnterFlightNo";
            this.lblEnterFlightNo.Size = new System.Drawing.Size(415, 20);
            this.lblEnterFlightNo.TabIndex = 35;
            this.lblEnterFlightNo.Text = "Enter below the flight number you want to book: ";
            // 
            // dgvAvailableTickets
            // 
            this.dgvAvailableTickets.AllowUserToAddRows = false;
            this.dgvAvailableTickets.AllowUserToDeleteRows = false;
            this.dgvAvailableTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTickets.Location = new System.Drawing.Point(16, 135);
            this.dgvAvailableTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAvailableTickets.Name = "dgvAvailableTickets";
            this.dgvAvailableTickets.ReadOnly = true;
            this.dgvAvailableTickets.RowHeadersWidth = 51;
            this.dgvAvailableTickets.Size = new System.Drawing.Size(1035, 294);
            this.dgvAvailableTickets.TabIndex = 29;
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTicket.Location = new System.Drawing.Point(680, 100);
            this.btnSearchTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(232, 28);
            this.btnSearchTicket.TabIndex = 28;
            this.btnSearchTicket.Text = "Search Available Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            this.btnSearchTicket.Click += new System.EventHandler(this.btnSearchTicket_Click);
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTo.Location = new System.Drawing.Point(589, 66);
            this.lblFlightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(95, 20);
            this.lblFlightTo.TabIndex = 34;
            this.lblFlightTo.Text = "Flight To: ";
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightFrom.Location = new System.Drawing.Point(568, 30);
            this.lblFlightFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(117, 20);
            this.lblFlightFrom.TabIndex = 32;
            this.lblFlightFrom.Text = "Flight From: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(16, 511);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // UserBookTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.lblEnterFlightNo);
            this.Controls.Add(this.dgvAvailableTickets);
            this.Controls.Add(this.btnSearchTicket);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.lblFlightFrom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserBookTicketsForm";
            this.ShowIcon = false;
            this.Text = "Book Tickets (User)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label lblEnterFlightNo;
        private System.Windows.Forms.DataGridView dgvAvailableTickets;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Label lblFlightTo;
        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Button btnBack;
    }
}