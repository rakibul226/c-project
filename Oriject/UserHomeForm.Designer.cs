
namespace AirwayTicketingApplication
{
    partial class UserHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomeForm));
            this.btnViewAvailableTickets = new System.Windows.Forms.Button();
            this.btnViewBookedTickets = new System.Windows.Forms.Button();
            this.btnCancelTickets = new System.Windows.Forms.Button();
            this.btnBookTickets = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnViewAvailableTickets
            // 
            this.btnViewAvailableTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAvailableTickets.Location = new System.Drawing.Point(790, 144);
            this.btnViewAvailableTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAvailableTickets.Name = "btnViewAvailableTickets";
            this.btnViewAvailableTickets.Size = new System.Drawing.Size(233, 37);
            this.btnViewAvailableTickets.TabIndex = 5;
            this.btnViewAvailableTickets.Text = "View Available Tickets";
            this.btnViewAvailableTickets.UseVisualStyleBackColor = true;
            this.btnViewAvailableTickets.Click += new System.EventHandler(this.btnViewAvailableTickets_Click);
            // 
            // btnViewBookedTickets
            // 
            this.btnViewBookedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookedTickets.Location = new System.Drawing.Point(790, 188);
            this.btnViewBookedTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewBookedTickets.Name = "btnViewBookedTickets";
            this.btnViewBookedTickets.Size = new System.Drawing.Size(233, 37);
            this.btnViewBookedTickets.TabIndex = 8;
            this.btnViewBookedTickets.Text = "View Booked Tickets";
            this.btnViewBookedTickets.UseVisualStyleBackColor = true;
            this.btnViewBookedTickets.Click += new System.EventHandler(this.btnViewBookedTickets_Click);
            // 
            // btnCancelTickets
            // 
            this.btnCancelTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTickets.Location = new System.Drawing.Point(790, 277);
            this.btnCancelTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelTickets.Name = "btnCancelTickets";
            this.btnCancelTickets.Size = new System.Drawing.Size(233, 37);
            this.btnCancelTickets.TabIndex = 9;
            this.btnCancelTickets.Text = "Cancel Tickets";
            this.btnCancelTickets.UseVisualStyleBackColor = true;
            this.btnCancelTickets.Click += new System.EventHandler(this.btnCancelTickets_Click);
            // 
            // btnBookTickets
            // 
            this.btnBookTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTickets.Location = new System.Drawing.Point(790, 233);
            this.btnBookTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookTickets.Name = "btnBookTickets";
            this.btnBookTickets.Size = new System.Drawing.Size(233, 37);
            this.btnBookTickets.TabIndex = 7;
            this.btnBookTickets.Text = "Book Tickets";
            this.btnBookTickets.UseVisualStyleBackColor = true;
            this.btnBookTickets.Click += new System.EventHandler(this.btnBookTickets_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(666, 65);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(487, 29);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome to Airway Ticketing Application";
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.BackColor = System.Drawing.Color.White;
            this.linkLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogout.ForeColor = System.Drawing.Color.White;
            this.linkLogout.LinkColor = System.Drawing.Color.Black;
            this.linkLogout.Location = new System.Drawing.Point(1096, 511);
            this.linkLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(74, 22);
            this.linkLogout.TabIndex = 14;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Log out";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked_1);
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 544);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnViewAvailableTickets);
            this.Controls.Add(this.btnViewBookedTickets);
            this.Controls.Add(this.btnCancelTickets);
            this.Controls.Add(this.btnBookTickets);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserHomeForm";
            this.ShowIcon = false;
            this.Text = "Home Page (User)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewAvailableTickets;
        private System.Windows.Forms.Button btnViewBookedTickets;
        private System.Windows.Forms.Button btnCancelTickets;
        private System.Windows.Forms.Button btnBookTickets;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel linkLogout;
    }
}