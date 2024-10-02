namespace Phumla_Kumnandi_Hotel_Reservation_System.Presentation
{
    partial class MDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton2 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.guestNavLabel = new System.Windows.Forms.Label();
            this.bookingNavLabel = new System.Windows.Forms.Label();
            this.homeNavLabel = new System.Windows.Forms.Label();
            this.bookingSystemDataSet1 = new Phumla_Kumnandi_Hotel_Reservation_System.bookingSystemDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookingSystemDataSet2 = new Phumla_Kumnandi_Hotel_Reservation_System.bookingSystemDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSystemDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.logoutButton2);
            this.panel1.Controls.Add(this.logoBox);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 730);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutButton2
            // 
            this.logoutButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton2.BackgroundImage")));
            this.logoutButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton2.Location = new System.Drawing.Point(12, 554);
            this.logoutButton2.Name = "logoutButton2";
            this.logoutButton2.Size = new System.Drawing.Size(36, 39);
            this.logoutButton2.TabIndex = 5;
            this.logoutButton2.UseVisualStyleBackColor = true;
            this.logoutButton2.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(47, 655);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(177, 44);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // guestNavLabel
            // 
            this.guestNavLabel.AutoSize = true;
            this.guestNavLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNavLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.guestNavLabel.Location = new System.Drawing.Point(409, 34);
            this.guestNavLabel.Name = "guestNavLabel";
            this.guestNavLabel.Size = new System.Drawing.Size(101, 32);
            this.guestNavLabel.TabIndex = 0;
            this.guestNavLabel.Text = "Guests";
            this.guestNavLabel.Click += new System.EventHandler(this.guestNavLabel_Click);
            // 
            // bookingNavLabel
            // 
            this.bookingNavLabel.AutoSize = true;
            this.bookingNavLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingNavLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bookingNavLabel.Location = new System.Drawing.Point(211, 34);
            this.bookingNavLabel.Name = "bookingNavLabel";
            this.bookingNavLabel.Size = new System.Drawing.Size(126, 32);
            this.bookingNavLabel.TabIndex = 0;
            this.bookingNavLabel.Text = "Bookings";
            this.bookingNavLabel.Click += new System.EventHandler(this.bookingNavLabel_Click);
            // 
            // homeNavLabel
            // 
            this.homeNavLabel.AutoSize = true;
            this.homeNavLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.homeNavLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeNavLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.homeNavLabel.Location = new System.Drawing.Point(64, 31);
            this.homeNavLabel.Name = "homeNavLabel";
            this.homeNavLabel.Size = new System.Drawing.Size(85, 32);
            this.homeNavLabel.TabIndex = 0;
            this.homeNavLabel.Text = "Home";
            this.homeNavLabel.Click += new System.EventHandler(this.homeNavLabel_Click);
            // 
            // bookingSystemDataSet1
            // 
            this.bookingSystemDataSet1.DataSetName = "bookingSystemDataSet";
            this.bookingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.guestNavLabel);
            this.panel2.Controls.Add(this.homeNavLabel);
            this.panel2.Controls.Add(this.bookingNavLabel);
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 72);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(706, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 60);
            this.panel7.TabIndex = 11;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(758, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rooms";
            this.label2.Click += new System.EventHandler(this.roomNavLabel_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(529, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 60);
            this.panel6.TabIndex = 9;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(583, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Promos";
            this.label1.Click += new System.EventHandler(this.promotionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(884, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 24);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(354, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 60);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(155, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 60);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 60);
            this.panel3.TabIndex = 4;
            // 
            // bookingSystemDataSet2
            // 
            this.bookingSystemDataSet2.DataSetName = "bookingSystemDataSet";
            this.bookingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome, Karen";
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.Location = new System.Drawing.Point(12, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(266, 99);
            this.logoBox.TabIndex = 4;
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1220, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent";
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSystemDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label guestNavLabel;
        private System.Windows.Forms.Label bookingNavLabel;
        private System.Windows.Forms.Label homeNavLabel;
        private bookingSystemDataSet bookingSystemDataSet1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private bookingSystemDataSet bookingSystemDataSet2;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel logoBox;
    }
}