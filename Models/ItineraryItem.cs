namespace TripTracker.Models
{
    public class ItineraryItem
    {
        public int TripID { get; set; }
        public int BookingID    { get; set; }
        public string BookingType { get; set; } = string.Empty;
        public string BookingName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

    }
}
