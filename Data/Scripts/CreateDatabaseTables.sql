-- Database Table Creation for TripTracker

CREATE TABLE Trips (
TripID INTEGER PRIMARY KEY,
UserID INTEGER NOT NULL,
TripName TEXT NOT NULL,
Description TEXT,
Destination TEXT NOT NULL,
StartDate DATE NOT NULL,
EndDate DATE NOT NULL,
BaseCurrency TEXT NOT NULL
);

CREATE TABLE TransportBookings (
TransportBookingID INTEGER PRIMARY KEY,
TripID INTEGER NOT NULL,
TransportType TEXT NOT NULL,
TransportProvider TEXT NOT NULL,
BookingPlatform TEXT NOT NULL,
BookingReference TEXT,
Price NUMERIC,
CurrencyCode TEXT NOT NULL,
DepartureDateTime DATE NOT NULL,
DepartureTimezone TEXT,
ArrivalDateTime DATE,
ArrivalTimezone TEXT,
FreeCancellation BOOLEAN,
CancellationDeadline DATE,
FOREIGN KEY (TripID) REFERENCES Trips(TripID)
)
