using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public interface IRideOrderingSystem
    {
        void PlaceRideOrder(string pickupLocation, string destination, int numberOfPassengers, string vehicleType);
       
        void PayForRide(decimal amount);
        void RateDriver(int driverId, int rating, string review);
        void ManageRideAdmin(int rideId, string action);
    }
}
