﻿namespace Phumla_Kumnandi_Hotel_Reservation_System.Presentation
{
    partial class BookingsForm
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
            this.bookingListView = new System.Windows.Forms.ListView();
            this.dataLanel = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookingListView
            // 
            this.bookingListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookingListView.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(12, 184);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(1149, 634);
            this.bookingListView.TabIndex = 14;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            this.bookingListView.SelectedIndexChanged += new System.EventHandler(this.bookingListView_SelectedIndexChanged_1);
            this.bookingListView.Click += new System.EventHandler(this.bookingListView_SelectedIndexChanged);
            // 
            // dataLanel
            // 
            this.dataLanel.AutoSize = true;
            this.dataLanel.BackColor = System.Drawing.Color.Transparent;
            this.dataLanel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLanel.ForeColor = System.Drawing.Color.Black;
            this.dataLanel.Location = new System.Drawing.Point(13, 64);
            this.dataLanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataLanel.Name = "dataLanel";
            this.dataLanel.Size = new System.Drawing.Size(239, 55);
            this.dataLanel.TabIndex = 15;
            this.dataLanel.Text = "Bookings";
            // 
            // searchInput
            // 
            this.searchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInput.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(724, 32);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(305, 43);
            this.searchInput.TabIndex = 16;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(1036, 26);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 54);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.Color.Transparent;
            this.showAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.showAllButton.FlatAppearance.BorderSize = 2;
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.ForeColor = System.Drawing.Color.Black;
            this.showAllButton.Location = new System.Drawing.Point(1036, 99);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(125, 54);
            this.showAllButton.TabIndex = 34;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1202, 860);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.dataLanel);
            this.Controls.Add(this.bookingListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BookingsForm";
            this.Activated += new System.EventHandler(this.BookingsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingsForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label dataLanel;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
    }
}