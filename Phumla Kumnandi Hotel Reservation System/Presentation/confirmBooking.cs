using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using Phumla_Kumnandi_Hotel_Reservation_System.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phumla_Kumnandi_Hotel_Reservation_System.Presentation
{
    public partial class ConfirmBooking : Form
    {
        #region instance variables

        private Booking booking;
        private Guest guest;
        private BookingController bookingController;

        #endregion
        #region constructor
        public ConfirmBooking(Guest guest, Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
            this.guest = guest;
            firstNameInput.Text = guest.FirstName;
            LastNameInput.Text = guest.LastName;
            checkInDateTimePicker.Value = booking.CheckInDate;
            checkOutDateTimePicker.Value = booking.CheckOutDate;
            numberOfGuestPicker.Value = booking.NumberOfGuests;
            firstNameInput.Enabled = false;
            LastNameInput.Enabled = false;
            checkInDateTimePicker.Enabled = false;
            checkOutDateTimePicker.Enabled = false;
            numberOfGuestPicker.Enabled = false;
            //specialRequestInput.Text = "Enter your request";
            this.specialRequestInput.Enter += new System.EventHandler(this.specialRequestInput_TextChanged);
            this.specialRequestInput.Leave += new System.EventHandler(this.specialRequestInput_Leave);
            specialRequestInput.ForeColor = Color.Gray;

            this.bookingController = MDIParent.GetBookingController();

        }
        #endregion
        private void PopulateObject()
        {
            if (specialRequestInput.Text == String.Empty)
            {
                booking.SpecialRequest = "none";
            }
            else
            {
                booking.SpecialRequest = specialRequestInput.Text;

            }
            booking.Id = GenerateUniqueId();
        }

        #region Utility function
        private const string AllowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private Random random = new Random();
        private string GenerateUniqueId()
        {
            // Get the current timestamp in milliseconds
            long timestamp = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

            // Generate a random part of the ID
            StringBuilder randomPart = new StringBuilder();
            for (int i = 0; i < 10; i++) // You can adjust the length as needed
            {
                int index = random.Next(AllowedChars.Length);
                randomPart.Append(AllowedChars[index]);
            }

            // Combine the timestamp and random part to create a unique ID
            string uniqueId = $"{timestamp}{randomPart.ToString().PadRight(15)}";

            // Ensure the ID is exactly 25 characters long
            uniqueId = uniqueId.Substring(0, 25);

            return uniqueId;
        }
        #endregion
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Add);
            bookingController.FinalizeChanges(booking);
           
            MessageBox.Show("Your Booking has been confirmed;)");
            this.Close();
  
        }
       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void specialRequestInput_TextChanged(object sender, EventArgs e)
        {
            if (specialRequestInput.Text == "Enter your request")
            {
                specialRequestInput.Text = "";
                specialRequestInput.ForeColor = Color.Black;
            }
        }
        private void specialRequestInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(specialRequestInput.Text))
            {
                specialRequestInput.Text = "Enter your request";
                specialRequestInput.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfirmBooking_Load(object sender, EventArgs e)
        {

        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
