namespace TripTracker.Models
{
    public class CurrencyRate
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public string FromCurrencyCode { get; set; } = string.Empty;
        public string ToCurrencyCode { get; set; } = "AUD";
        public decimal ExchangeRate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
