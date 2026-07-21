namespace TripTracker.Models
{
    public abstract class Booking
    {
        public int BookingID {  get; set; }
        public int TripID { get; set; }
        public string BookingProvider { get; set; } = string.Empty;
        public string BookingReference { get; set; } = string.Empty;
        public string? BookingReservationName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "AUD";
        public bool IsCancellable { get; set; }
        public DateOnly? CancellationDeadline { get; set; }
        


    }
}
