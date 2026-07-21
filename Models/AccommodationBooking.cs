namespace TripTracker.Models
{
    public class AccommodationBooking : Booking
    {
        public string AccommodationName { get; set; } = string.Empty;
        public string AccommodationType { get; set; } = string.Empty;
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public bool IncludesBreakfast { get; set; }
        public string? Amenities {  get; set; }
        public string? HotelStars { get; set; }


    }
}
