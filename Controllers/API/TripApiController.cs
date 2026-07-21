using Microsoft.AspNetCore.Mvc;
using TripTracker.Models;

namespace TripTracker.Controllers.Api
{
    [ApiController]
    [Route("api/trips")]
    public class TripsApiController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetTrips()
        {
            return new JsonResult(
                // Sample data initially for prototype
                // Eventually this will return authenticated trips rather than sample data.
                new List<object>
                {
                    new
                    {
                        tripId = 1,
                        tripName = "Europe Trip 2026",
                        destination = "Europe",
                        startDate = "2026-07-01",
                        endDate = "2026-08-01",
                        baseCurrency = "AUD"
                    },
                    new
                    {
                        tripId = 2,
                        tripName = "Japan Trip 2027",
                        destination = "Japan",
                        startDate = "2027-01-10",
                        endDate = "2027-01-24",
                        baseCurrency = "AUD"
                    }
                });
        }

        [HttpPost]
        public  JsonResult PostTrip(Trip newTrip)
        {
            return new JsonResult(
                new
                {
                    message = "Trip added successfully",
                    tripId = 3,
                    tripName = newTrip.TripName,
                    destination = newTrip.TripDestination,
                    startDate = newTrip.StartDate,
                    endDate = newTrip.EndDate,
                    baseCurrency = newTrip.BaseCurrency
                });
        }
    }
}