
namespace AirwayTicketingApplication
{
    partial class AdminAddTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddTicketsForm));
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.lblFlightTo = new System.Windows.Forms.Label();
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbFrom.Location = new System.Drawing.Point(725, 176);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(210, 28);
            this.cbFrom.Sorted = true;
            this.cbFrom.TabIndex = 17;
            // 
            // cbTo
            // 
            this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbTo.Location = new System.Drawing.Point(725, 208);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(210, 28);
            this.cbTo.Sorted = true;
            this.cbTo.TabIndex = 18;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = " ";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(228, 240);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(185, 26);
            this.dtpTime.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(228, 210);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 26);
            this.dtpDate.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(725, 240);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 26);
            this.txtPrice.TabIndex = 20;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(623, 242);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 20);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Price: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(127, 243);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 20);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Time: ";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.ForeColor = System.Drawing.Color.Black;
            this.btnAddTicket.Location = new System.Drawing.Point(787, 281);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(148, 28);
            this.btnAddTicket.TabIndex = 21;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTo.ForeColor = System.Drawing.Color.Transparent;
            this.lblFlightTo.Location = new System.Drawing.Point(604, 210);
            this.lblFlightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(95, 20);
            this.lblFlightTo.TabIndex = 22;
            this.lblFlightTo.Text = "Flight To: ";
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightFrom.ForeColor = System.Drawing.Color.Transparent;
            this.lblFlightFrom.Location = new System.Drawing.Point(588, 178);
            this.lblFlightFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(117, 20);
            this.lblFlightFrom.TabIndex = 19;
            this.lblFlightFrom.Text = "Flight From: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(128, 208);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 20);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date: ";
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(228, 179);
            this.txtFlightNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(185, 26);
            this.txtFlightNo.TabIndex = 12;
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.lblFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNo.ForeColor = System.Drawing.Color.Transparent;
            this.lblFlightNo.Location = new System.Drawing.Point(50, 180);
            this.lblFlightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(139, 20);
            this.lblFlightNo.TabIndex = 13;
            this.lblFlightNo.Text = "Flight Number: ";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(16, 395);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // AdminAddTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 438);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.lblFlightFrom);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.lblFlightNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAddTicketsForm";
            this.ShowIcon = false;
            this.Text = "Add Tickets (Admin)";
            this.Load += new System.EventHandler(this.AdminAddTicketsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Label lblFlightTo;
        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.Button btnBack;
    }
}