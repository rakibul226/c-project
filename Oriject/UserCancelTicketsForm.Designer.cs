
namespace AirwayTicketingApplication
{
    partial class UserCancelTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCancelTicketsForm));
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblEnterFlightNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.Location = new System.Drawing.Point(843, 64);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(183, 36);
            this.btnCancelBooking.TabIndex = 29;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNo.Location = new System.Drawing.Point(775, 28);
            this.txtFlightNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(249, 26);
            this.txtFlightNo.TabIndex = 28;
            // 
            // lblEnterFlightNo
            // 
            this.lblEnterFlightNo.AutoSize = true;
            this.lblEnterFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFlightNo.Location = new System.Drawing.Point(320, 31);
            this.lblEnterFlightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterFlightNo.Name = "lblEnterFlightNo";
            this.lblEnterFlightNo.Size = new System.Drawing.Size(447, 20);
            this.lblEnterFlightNo.TabIndex = 31;
            this.lblEnterFlightNo.Text = "Enter the flight number you want to cancel booking: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(16, 394);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 28);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // UserCancelTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 437);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.lblEnterFlightNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserCancelTicketsForm";
            this.ShowIcon = false;
            this.Text = "Cancel Tickets (User) ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label lblEnterFlightNo;
        private System.Windows.Forms.Button btnBack;
    }
}