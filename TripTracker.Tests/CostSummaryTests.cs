using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTracker.Models;
using TripTracker.Services;

namespace TripTracker.Tests
{
    public class CostSummaryTests
    {
        // Declare a private read-only instance of the calculation class
        private readonly CostSummaryCalculation _calculationTest;

        // Constructor for CostSummaryTests class
        public CostSummaryTests()
        {
            //Initialise new CostSummary instance
            _calculationTest = new CostSummaryCalculation();
        }

        //Test 1: Test service to ensure totals add up
        [Fact]
        public void CalculateCostsSummary_ReturnCorrectTotals()
        {
            // Create dummy lists of bookings
            var transportBookings = new List<TransportBooking>
            {
                new TransportBooking { Price = 1200.00m },
                new TransportBooking { Price = 800.00m }
            };

            var accommodationBookings = new List<AccommodationBooking>
            {
                new AccommodationBooking { Price = 2500.00m },
                new AccommodationBooking { Price = 1000.00m }
            };

            var activityBookings = new List<ActivityBooking>
            {
                new ActivityBooking { Price = 300.00m },
                new ActivityBooking { Price = 300.00m }
            };

            var result = _calculationTest.CalculateCostSummary(1, "AUD", transportBookings, accommodationBookings, activityBookings);

            Assert.Equal(2000.00m, result.TotalTransportCosts);
            Assert.Equal(3500.00m, result.TotalAccommodationCosts);
            Assert.Equal(600.00m, result.TotalActivityCosts);
            Assert.Equal(6100.00m, result.TotalTripCosts);
            Assert.Equal("AUD", result.BaseCurrency);
            Assert.Equal(1, result.TripID);
        }

        //Test 2: Test service to ensure totals add up to zero
        [Fact]
        public void CalculateCostsSummary_ReturnZerosWhenNoBookings()
        {
            // Create dummy lists of bookings
            var transportBookings = new List<TransportBooking>();
            var accommodationBookings = new List<AccommodationBooking>();
            var activityBookings = new List<ActivityBooking>();

            var result = _calculationTest.CalculateCostSummary(1, "AUD", transportBookings, accommodationBookings, activityBookings);

            Assert.Equal(0.00m, result.TotalTransportCosts);
            Assert.Equal(0.00m, result.TotalAccommodationCosts);
            Assert.Equal(0.00m, result.TotalActivityCosts);
            Assert.Equal(0.00m, result.TotalTripCosts);
            Assert.Equal("AUD", result.BaseCurrency);
            Assert.Equal(1, result.TripID);
        }


        //Test 3: Test service to ensure totals add up when only accommodation bookings are present
        [Fact]
        public void CalculateCostsSummary_ReturnCorrectTotalsWhenOnlyAccommodationBookings()
        {
            // Create dummy lists of bookings
            var transportBookings = new List<TransportBooking>();


            var accommodationBookings = new List<AccommodationBooking>
            {
                new AccommodationBooking { Price = 2500.00m },
                new AccommodationBooking { Price = 1000.00m },
                new AccommodationBooking { Price = 800.00m },
                new AccommodationBooking { Price = 1200.00m }
            };

            var activityBookings = new List<ActivityBooking>();

            var result = _calculationTest.CalculateCostSummary(1, "AUD", transportBookings, accommodationBookings, activityBookings);

            Assert.Equal(0.00m, result.TotalTransportCosts);
            Assert.Equal(5500.00m, result.TotalAccommodationCosts);
            Assert.Equal(0.00m, result.TotalActivityCosts);
            Assert.Equal(5500.00m, result.TotalTripCosts);
            Assert.Equal("AUD", result.BaseCurrency);
            Assert.Equal(1, result.TripID);
        }
    }
}
