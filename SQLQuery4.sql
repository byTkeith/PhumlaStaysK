CREATE TABLE Bookings (
    Id NVARCHAR(50) PRIMARY KEY,
    GuestId NVARCHAR(50),
    CheckInDate DATETIME,
    CheckOutDate DATETIME,
    NumberOfRooms INT,
    SpecialRequest NVARCHAR(255),
    NumberOfGuests INT,
    Deposit INT,
    TotalAmount INT,
    BookingStatusId INT,
    CONSTRAINT FK_Bookings_Guests FOREIGN KEY (GuestId) REFERENCES Guests(GuestID)
);