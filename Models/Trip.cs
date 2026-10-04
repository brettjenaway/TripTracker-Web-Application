namespace TripTracker.Models
{
    public class Trip
    {
        public int TripID {  get; set; }
        public string UserID { get; set; } = string.Empty;
        public string TripName { get; set; } = string.Empty;
        public string? TripDescription { get; set; }
        public string TripDestination { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string BaseCurrency { get; private set; } = "AUD";

        public void SetBaseCurrency(string baseCurrency)
        {
            if (string.IsNullOrEmpty(baseCurrency))
            {
                throw new ArgumentException("Base currency is required");
            }

            BaseCurrency = baseCurrency;
        }
    }

    

}
