-- Inserts sample data into the database

INSERT INTO Users (
UserID, UserName
)
VALUES (
1, 'brett@sampledata.com'
);

INSERT INTO Trips (
TripID,
    UserID,
    TripName,
    Description,
    Destination,
    StartDate,
    EndDate,
    BaseCurrency
)
VALUES (
    1,
    1,
    'Europe Trip 2026',
    'One month trip through Europe',
    'Europe',
    '2026-07-01',
    '2026-08-01',
    'AUD'
);

INSERT INTO TransportBookings (
    TransportBookingID,
    TripID,
    TransportType,
    TransportProvider,
    BookingPlatform,
    BookingReference,
    Price,
    CurrencyCode,
    DepartureDateTime,
    DepartureTimezone,
    ArrivalDateTime,
    ArrivalTimezone,
    FreeCancellation,
    CancellationDeadline
)
VALUES (
    1,
    1,
    'Flight',
    'Qantas',
    'Qantas Website',
    'QF123ABC',
    1800.00,
    'AUD',
    '2026-07-01T08:00:00',
    'Australia/Perth',
    '2026-07-01T22:00:00',
    'Europe/London',
    0,
    NULL
);