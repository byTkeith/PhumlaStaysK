﻿CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    GuestID INT,
    CheckInDate DATE,
    CheckOutDate DATE,
    RoomType NVARCHAR(50),
    Season NVARCHAR(50),
    RoomRate DECIMAL(10, 2),
    DepositPaid DECIMAL(10, 2),
    FOREIGN KEY (GuestID) REFERENCES Guests(GuestID)
);