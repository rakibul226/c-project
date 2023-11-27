
namespace AirwayTicketingApplication
{
    partial class AdminRemoveTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRemoveTicketsForm));
            this.btnRemoveTicket = new System.Windows.Forms.Button();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblEnterFlightNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTicket.Location = new System.Drawing.Point(465, 46);
            this.btnRemoveTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(155, 28);
            this.btnRemoveTicket.TabIndex = 6;
            this.btnRemoveTicket.Text = "Remove Ticket";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNo.Location = new System.Drawing.Point(465, 11);
            this.txtFlightNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(207, 26);
            this.txtFlightNo.TabIndex = 5;
            // 
            // lblEnterFlightNo
            // 
            this.lblEnterFlightNo.AutoSize = true;
            this.lblEnterFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFlightNo.ForeColor = System.Drawing.Color.White;
            this.lblEnterFlightNo.Location = new System.Drawing.Point(16, 11);
            this.lblEnterFlightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterFlightNo.Name = "lblEnterFlightNo";
            this.lblEnterFlightNo.Size = new System.Drawing.Size(435, 25);
            this.lblEnterFlightNo.TabIndex = 7;
            this.lblEnterFlightNo.Text = "Enter the flight number you want to remove: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(601, 524);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // AdminRemoveTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 567);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveTicket);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.lblEnterFlightNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminRemoveTicketsForm";
            this.ShowIcon = false;
            this.Text = "Remove Tickets (Admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTicket;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label lblEnterFlightNo;
        private System.Windows.Forms.Button btnBack;
    }
}