﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kumnandi_Hotel_Reservation_System.Business;
namespace Phumla_Kumnandi_Hotel_Reservation_System.Presentation
{
    public partial class RoomAvailableBox : Form
    {
        private Booking booking;
        private GuestController guestController;
        private BookingController bookingController;
        public RoomAvailableBox(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
            this.guestController = MDIParent.GetGuestController();
            this.bookingController = MDIParent.GetBookingController();
            bookingPriceLabel.Text = booking.TotalAmount.ToString();
        }



        private void RoomAvailableBox_Load(object sender, EventArgs e)
        {

        }

        private void createBookingButton_Click(object sender, EventArgs e)
        {
            this.Close();

            CreateGuest createGuest = new CreateGuest(booking);
            createGuest.ShowDialog();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
