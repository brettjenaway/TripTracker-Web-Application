namespace TripTracker.Models
{
    public class AccommodationOverlap
    {
        public int TripID { get; set; }
        public int FirstAccommodationBookingID { get; set; }
        public string FirstAccommodationName { get; set; } = string.Empty;
        public string FirstAccommodationLocation { get; set; } = string.Empty;
        public DateOnly FirstAccommodationCheckIn { get; set; }
        public int SecondAccommodationBookingID { get; set; }
        public string SecondAccommodationName { get; set; } = string.Empty;
        public string SecondAccommodationLocation { get; set; } = string.Empty;
        public DateOnly SecondAccommodationCheckIn { get; set; }
        public DateOnly OverlapStartDate { get; set; }
        public DateOnly OverlapEndDate { get; set; }    
        public string Message { get; set; } = string.Empty;
    }
}
