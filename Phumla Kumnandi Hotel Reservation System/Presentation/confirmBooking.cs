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
            specialRequestInput.Text = "Enter your request";
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
           
            MessageBox.Show("YouBooking has been confirmed;)");
  EmailGuest();
            this.Close();
          


        }
        private void EmailGuest()
        {
            string senderEmail = "phumla056@gmail.com";
            string senderPassword = "rhni jiwt mrvi ewln";

            // Recipient's email address
            string recipientEmail = guest.Email;

            // Create a new MailMessage
            // Create a new MailMessage
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(recipientEmail);
            mail.Subject = "PhumlaStays: Booking Confirmed";
            mail.Body = $"Dear {guest.Title} {guest.LastName},\n\n" +
            $"Thank you for booking with us from: {booking.CheckInDate:yyyy-MM-dd} to {booking.CheckOutDate:yyyy-MM-dd} at Phumla Kumnandi Hotel. We look forward to welcoming you and ensuring that your stay is comfortable and enjoyable.\n\n" +
            "Booking Details:\n" +
            $"- Check-in Date: {booking.CheckInDate:yyyy-MM-dd}\n" +
            $"- Check-out Date: {booking.CheckOutDate:yyyy-MM-dd}\n\n" +
            $"Please kindly confirm your booking by making a confirmation deposit of the amount {booking.TotalAmount:C2} payable using:\n\n" +
            "Bank Transfer Details:\n" +
            "Bank Name: TendaiExec Bank\n" +
            "Account Holder: PhumlaStays Inc\n" +
            "Account Number: 000000 00000 00\n" +
            "IBAN: 123\n" +
            "SWIFT/BIC Code: 123\n\n" +
            $"Kindly include your booking reference number, {booking.Id}.\n\n" +

            "Once we receive your deposit payment, we will send you a confirmation email along with any additional details you may need for your stay.\n\n" +
            "Thank you for choosing Phumla Hotels. We are excited to host you, and we are confident that your stay with us will be a memorable one. If you have any special requests or preferences, please let us know in advance so that we can make arrangements to enhance your experience.\n\n" +
            "We appreciate your trust in us and look forward to providing you with exceptional service.\n\n" +
            "Warm regards,\n" +
            "Receptionist\n" +

            "PhumlaStays Inc\n" +
            "phumlaStaysInc@co.za\n" +
            "000000000";

            // Create a new SmtpClient
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            try
            {
                // Send the email
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

            }
            finally
            {
                // Clean up resources
                mail.Dispose();
                smtpClient.Dispose();
            }
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
