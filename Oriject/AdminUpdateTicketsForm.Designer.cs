
namespace AirwayTicketingApplication
{
    partial class AdminUpdateTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdateTicketsForm));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.lblFlightTo = new System.Windows.Forms.Label();
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnterFlightNo = new System.Windows.Forms.Label();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(815, 61);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 26);
            this.dtpDate.TabIndex = 29;
            // 
            // cbFrom
            // 
            this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.ItemHeight = 20;
            this.cbFrom.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cox Bazar",
            "Dhaka",
            "Jessore",
            "Rajshahi",
            "Saidpur",
            "Sylhet"});
            this.cbFrom.Location = new System.Drawing.Point(815, 125);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(185, 28);
            this.cbFrom.Sorted = true;
            this.cbFrom.TabIndex = 31;
            // 
            // cbTo
            // 
            this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.ItemHeight = 20;
            this.cbTo.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cox Bazar",
            "Dhaka",
            "Jessore",
            "Rajshahi",
            "Saidpur",
            "Sylhet"});
            this.cbTo.Location = new System.Drawing.Point(815, 158);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(185, 28);
            this.cbTo.Sorted = true;
            this.cbTo.TabIndex = 33;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(815, 191);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(185, 26);
            this.txtPrice.TabIndex = 35;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(736, 191);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 20);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Price: ";
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.Location = new System.Drawing.Point(877, 237);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(123, 28);
            this.btnUpdateTicket.TabIndex = 37;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFlightTo.Location = new System.Drawing.Point(706, 158);
            this.lblFlightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(95, 20);
            this.lblFlightTo.TabIndex = 41;
            this.lblFlightTo.Text = "Flight To: ";
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightFrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFlightFrom.Location = new System.Drawing.Point(684, 125);
            this.lblFlightFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(117, 20);
            this.lblFlightFrom.TabIndex = 40;
            this.lblFlightFrom.Text = "Flight From: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(739, 98);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 20);
            this.lblTime.TabIndex = 39;
            this.lblTime.Text = "Time: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(740, 66);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 20);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(633, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enter New Details:";
            // 
            // lblEnterFlightNo
            // 
            this.lblEnterFlightNo.AutoSize = true;
            this.lblEnterFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFlightNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterFlightNo.Location = new System.Drawing.Point(50, 58);
            this.lblEnterFlightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterFlightNo.Name = "lblEnterFlightNo";
            this.lblEnterFlightNo.Size = new System.Drawing.Size(372, 20);
            this.lblEnterFlightNo.TabIndex = 32;
            this.lblEnterFlightNo.Text = "Enter the flight number you want to update:";
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNo.Location = new System.Drawing.Point(295, 92);
            this.txtFlightNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(127, 26);
            this.txtFlightNo.TabIndex = 28;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(13, 380);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = " ";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(814, 93);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(186, 26);
            this.dtpTime.TabIndex = 2;
            // 
            // AdminUpdateTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 421);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.lblFlightFrom);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterFlightNo);
            this.Controls.Add(this.txtFlightNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUpdateTicketsForm";
            this.ShowIcon = false;
            this.Text = "Update Tickets (Admin)";
            this.Load += new System.EventHandler(this.AdminUpdateTicketsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Label lblFlightTo;
        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnterFlightNo;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}