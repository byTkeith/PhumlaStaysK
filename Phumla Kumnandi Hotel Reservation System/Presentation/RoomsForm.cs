using Phumla_Kumnandi_Hotel_Reservation_System.Business;
using Phumla_Kumnandi_Hotel_Reservation_System.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kumnandi_Hotel_Reservation_System.Business;
using Phumla_Kumnandi_Hotel_Reservation_System.Data;
using static Phumla_Kumnandi_Hotel_Reservation_System.Presentation.BookingsForm;


namespace Phumla_Kumnandi_Hotel_Reservation_System.Presentation
{
    public partial class RoomsForm : Form
    {
        public bool listFormClosed;
       // public bool listFormClosed;
        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        private BookingController bookingController;
        private GuestController guestController;
        private FormState state;
        private Booking booking;
        private Guest guest;
        public RoomsForm()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateRooms();
            //PopulateRooms();
        }
       
        private void SetupDataGridView()
        {
            ListViewItem guestDetails;
            dataGridView1.Columns.Clear();
            //bookings = bookingController.AllBookings;
            //guests = guestController.AllGuests;
            dataGridView1.Columns.Clear(); // Clear existing columns
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("roomDescription", "Room Description");
            dataGridView1.Columns.Add("roomAvailable", "Available");
            dataGridView1.Columns.Add("roomNumber", "Room Number");

            // set properties like auto-size
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["roomDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["roomAvailable"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["roomNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                string stringRoomID = searchBox.Text;
                int roomId = int.Parse(stringRoomID);
                RoomController roomcontroller = new RoomController();
                 
                Room aRoom = roomcontroller.Find(roomId);

                if (string.IsNullOrEmpty(stringRoomID))
                {
                    MessageBox.Show("Please enter a GuestID to searc", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (aRoom == null)
                {
                    MessageBox.Show("Guest does not exist in our system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(aRoom.Id, aRoom.RoomNumber, aRoom.RoomDescription, aRoom.RoomAvailability, aRoom.Rate);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure all fields are correctly flled in before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
        public void PopulateRooms()
        {
            try
            {
                RoomController roomcontroller = new RoomController();
                Collection<Room> allRooms = roomcontroller.AllRooms;
                dataGridView1.Rows.Clear();

                foreach (Room room in allRooms)
                {
                    dataGridView1.Rows.Add(
                        room.RoomAvailibility,
                        room.RoomDescription,
                        //room.rate,
                        room.Id);
                      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error occured while listing all guests{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
    }
}
