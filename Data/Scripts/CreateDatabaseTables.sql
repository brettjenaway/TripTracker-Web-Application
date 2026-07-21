CREATE TABLE Trips (
TripID INTEGER PRIMARY KEY,
UserID INTEGER NOT NULL,
TripName TEXT NOT NULL,
Description TEXT,
Destination TEXT NOT NULL,
StartDate TEXT NOT NULL,
EndDate TEXT NOT NULL,
BaseCurrency TEXT NOT NULL
);

CREATE TABLE TransportBookings (
TransportBookingID INTEGER PRIMARY KEY,
TripID INTEGER NOT NULL,
TransportType TEXT NOT NULL,
TransportProvider TEXT NOT NULL,
BookingPlatform TEXT NOT NULL,
BookingReference TEXT,
Price DECIMAL(10,2),
CurrencyCode TEXT,
DepartureDateTime DATE NOT NULL,
DepartureTimezone DATE,
ArrivalDateTime TEXT,
ArrivalTimezone TEXT,
FreeCancellation TEXT,
CancellationDeadline DATE
FOREIGN KEY (TripID) REFERENCES Trips(TripID)
)
