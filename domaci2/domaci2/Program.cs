using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
     class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje sistema za naručivanje vožnje
            IRideOrderingSystem rideOrderingSystem = new RideOrderingSystem();

            // Kreiranje fasade
            RideOrderingFacade rideOrderingFacade = new RideOrderingFacade(rideOrderingSystem);

            // Primjer korištenja fasade
            rideOrderingFacade.PlaceRideOrder("LokacijaPreuzimanja", "Odredište", 2, "Ekonomija");
            rideOrderingFacade.PayForRide(20.50m);
            rideOrderingFacade.RateDriver(123, 5, "Odlična vožnja!");
            rideOrderingFacade.ManageRideAdmin(456, "Otkaži");
            Console.ReadLine();
        }
    }
}
