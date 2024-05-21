using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class RideOrderingFacade
    {
        private IRideOrderingSystem _rideOrderingSystem;

        public RideOrderingFacade(IRideOrderingSystem rideOrderingSystem)
        {
            _rideOrderingSystem = rideOrderingSystem;
        }

        public void PlaceRideOrder(string pickupLocation, string destination, int numberOfPassengers, string vehicleType)
        {
            _rideOrderingSystem.PlaceRideOrder(pickupLocation, destination, numberOfPassengers, vehicleType);
        }

        public void PayForRide(decimal amount)
        {
            _rideOrderingSystem.PayForRide(amount);
        }

        public void RateDriver(int driverId, int rating, string review)
        {
            _rideOrderingSystem.RateDriver(driverId, rating, review);
        }

        public void ManageRideAdmin(int rideId, string action)
        {
            _rideOrderingSystem.ManageRideAdmin(rideId, action);
        }
    }
}
