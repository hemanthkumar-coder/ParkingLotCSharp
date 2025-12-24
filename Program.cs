

using ParkingLotApp.Interfaces;
using ParkingLotApp.ParkingSpaceClasses;
using ParkingLotApp.ParkingVehicleClasses;

namespace ParkingLotApp
{
    class MainClass
    {
        public static void Main()
        {
            IVehicle car = new Car();
            car.PullingOutVehicle();

        }
    }
}