using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    internal class RideOrderingSystem : IRideOrderingSystem
    {
        public void PlaceRideOrder(string pickupLocation, string destination, int numberOfPassengers, string vehicleType)
        {
            // Implementacija za naručivanje vožnje
            Console.WriteLine("Narudžba vožnje uspješno izvršena.");
        }

        public void PayForRide(decimal amount)
        {
            // Implementacija za plaćanje vožnje
            Console.WriteLine("Plaćanje uspješno izvršeno.");
        }

        public void RateDriver(int driverId, int rating, string review)
        {
            // Implementacija za ocjenjivanje vozača
            Console.WriteLine("Vozač uspješno ocijenjen.");
        }

        public void ManageRideAdmin(int rideId, string action)
        {
            // Implementacija za administrativne akcije na vožnji
            Console.WriteLine("Administrativna akcija na vožnji uspješno izvršena.");
        }
    }
}
