
namespace AirwayTicketingApplication
{
    partial class AdminHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewAllTickets = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.btnViewAllBookedTickets = new System.Windows.Forms.Button();
            this.btnRemoveTickets = new System.Windows.Forms.Button();
            this.btnUpdateTickets = new System.Windows.Forms.Button();
            this.btnAddTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(108, 63);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(157, 34);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // btnViewAllTickets
            // 
            this.btnViewAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTickets.Location = new System.Drawing.Point(64, 119);
            this.btnViewAllTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllTickets.Name = "btnViewAllTickets";
            this.btnViewAllTickets.Size = new System.Drawing.Size(248, 28);
            this.btnViewAllTickets.TabIndex = 8;
            this.btnViewAllTickets.Text = "View All Tickets";
            this.btnViewAllTickets.UseVisualStyleBackColor = true;
            this.btnViewAllTickets.Click += new System.EventHandler(this.btnViewAllTickets_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.BackColor = System.Drawing.Color.White;
            this.linkLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogout.ForeColor = System.Drawing.Color.White;
            this.linkLogout.LinkColor = System.Drawing.Color.Black;
            this.linkLogout.Location = new System.Drawing.Point(872, 426);
            this.linkLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(74, 22);
            this.linkLogout.TabIndex = 13;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Log out";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // btnViewAllBookedTickets
            // 
            this.btnViewAllBookedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllBookedTickets.Location = new System.Drawing.Point(64, 155);
            this.btnViewAllBookedTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllBookedTickets.Name = "btnViewAllBookedTickets";
            this.btnViewAllBookedTickets.Size = new System.Drawing.Size(248, 28);
            this.btnViewAllBookedTickets.TabIndex = 12;
            this.btnViewAllBookedTickets.Text = "View All Booked Tickets";
            this.btnViewAllBookedTickets.UseVisualStyleBackColor = true;
            this.btnViewAllBookedTickets.Click += new System.EventHandler(this.btnViewAllBookedTickets_Click);
            // 
            // btnRemoveTickets
            // 
            this.btnRemoveTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTickets.Location = new System.Drawing.Point(64, 226);
            this.btnRemoveTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveTickets.Name = "btnRemoveTickets";
            this.btnRemoveTickets.Size = new System.Drawing.Size(248, 28);
            this.btnRemoveTickets.TabIndex = 11;
            this.btnRemoveTickets.Text = "Remove Tickets";
            this.btnRemoveTickets.UseVisualStyleBackColor = true;
            this.btnRemoveTickets.Click += new System.EventHandler(this.btnRemoveTickets_Click);
            // 
            // btnUpdateTickets
            // 
            this.btnUpdateTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTickets.Location = new System.Drawing.Point(64, 262);
            this.btnUpdateTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateTickets.Name = "btnUpdateTickets";
            this.btnUpdateTickets.Size = new System.Drawing.Size(248, 28);
            this.btnUpdateTickets.TabIndex = 10;
            this.btnUpdateTickets.Text = "Update Tickets";
            this.btnUpdateTickets.UseVisualStyleBackColor = true;
            this.btnUpdateTickets.Click += new System.EventHandler(this.btnUpdateTickets_Click);
            // 
            // btnAddTickets
            // 
            this.btnAddTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTickets.Location = new System.Drawing.Point(64, 191);
            this.btnAddTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTickets.Name = "btnAddTickets";
            this.btnAddTickets.Size = new System.Drawing.Size(248, 28);
            this.btnAddTickets.TabIndex = 9;
            this.btnAddTickets.Text = "Add Tickets";
            this.btnAddTickets.UseVisualStyleBackColor = true;
            this.btnAddTickets.Click += new System.EventHandler(this.btnAddTickets_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 459);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnViewAllTickets);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnViewAllBookedTickets);
            this.Controls.Add(this.btnRemoveTickets);
            this.Controls.Add(this.btnUpdateTickets);
            this.Controls.Add(this.btnAddTickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminHomeForm";
            this.ShowIcon = false;
            this.Text = "Home Page (Admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewAllTickets;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Button btnViewAllBookedTickets;
        private System.Windows.Forms.Button btnRemoveTickets;
        private System.Windows.Forms.Button btnUpdateTickets;
        private System.Windows.Forms.Button btnAddTickets;
    }
}