using TripTracker.Models;

namespace TripTracker.Services
{
    // Take the booking data, add up the costs, and return a CostSummary object.
    public class CostSummaryCalculation
    {
        // Returns a CostSummary object with parameters tripID, baseCurrency,
        // transportBookings, accommodationBookings, activityBookings
        public CostSummary CalculateCostSummary(
            int tripID,
            string baseCurrency,
            List<TransportBooking> transportBookings,
            List<AccommodationBooking> accommodationBookings,
            List<ActivityBooking> activityBookings)
        {
            // Loop through every transport booking sum the price
            // This is assuming they all in one currency
            decimal transportTotal = transportBookings.Sum(c => c.Price);
            decimal accommodationTotal = accommodationBookings.Sum(c => c.Price);
            decimal activityTotal = activityBookings.Sum(c => c.Price);

            // Sum the three separate totals for the overall total
            decimal tripTotal = transportTotal + accommodationTotal + activityTotal;

            // Return new cost summary object with totals
            return new CostSummary
            {
                TripID = tripID,
                BaseCurrency = baseCurrency,
                TotalTransportCosts = transportTotal,
                TotalAccommodationCosts = accommodationTotal,
                TotalActivityCosts = activityTotal,
                TotalTripCosts = tripTotal
            };
        }
    }
}
