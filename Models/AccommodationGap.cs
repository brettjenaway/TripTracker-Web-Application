namespace TripTracker.Models
{
    public class AccommodationGap
    {
        public int TripID   { get; set; }
        public DateOnly GapStartDate { get; set; }
        public DateTime GapEndDate { get; set; }
        public int NumberOfNights { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
