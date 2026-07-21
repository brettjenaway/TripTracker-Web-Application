namespace TripTracker.Models
{
    public class ActivityBooking : Booking
    {
        public string ActivityBookingName { get; set; } = string.Empty;
        public string ActivityBookingStatus { get; set; } = string.Empty;
        public string ActivityType { get; set; } = string.Empty;
        public string? ActivityLocation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

    }
}
