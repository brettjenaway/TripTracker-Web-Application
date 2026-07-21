namespace TripTracker.Models
{
    public class TransportBooking : Booking
    {
        public string TransportName { get; set; } = string.Empty;
        public string TransportType { get; set; } = string.Empty;
        public string? SeatNumber { get; set; }
        public string DepartureLocation { get; set; } = string.Empty;
        public string ArrivalLocation { get; set; } = string.Empty;
        public DateTime DepartureTime {  get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
