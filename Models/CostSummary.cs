namespace TripTracker.Models
{
    public class CostSummary
    {
        public int TripID { get; set; }
        public string BaseCurrency { get; set; } = string.Empty;
        public decimal TotalTransportCosts {  get; set; }
        public decimal TotalAccommodationCosts   { get; set; }
        public decimal TotalActivityCosts { get; set; }
        public decimal TotalTripCosts { get; set; }
    }
}
