using ParkingLotApp.Interfaces;
using ParkingLotApp.ParkingSpaceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.ParkingVehicleClasses
{
    class Car : IVehicle
    {
        IParkingSpace CarParkingSpace;
        private string _CarName;
        public string CarName
        {
            get
            {
                return _CarName;
            }
        }
        public Car(string carName)
        {
            _CarName = carName;
            this.CarParkingSpace = new CarParkingSpace();
        }
        public void ParkVehicle()
        {
            if (CarParkingSpace.IsAlreadyParked(CarName))
            {
                Console.WriteLine("Vehicle Already Parked");
                return;
            }

            bool IsSpaceAvailiable = CarParkingSpace.isSpaceAvailiable();
            if (IsSpaceAvailiable)
            {
                bool IsSpaceUpdated = CarParkingSpace.UpdateParkingSpace(true,CarName);
                if (IsSpaceUpdated)
                {
                    Console.WriteLine("Car Parked Successfully...");
                    return;
                }
                Console.WriteLine("Error Occured");
            }
            else
            {
                Console.WriteLine("No Space Availiable To Park the Vehicle");
            }
        }

        public void PullingOutVehicle()
        {
            if (!CarParkingSpace.IsAlreadyParked(CarName))
            {
                Console.WriteLine("Bike Not Parked Anywhere");
                return;
            }

            bool IsSpaceUpdated = CarParkingSpace.UpdateParkingSpace(false,CarName);
            if (IsSpaceUpdated)
            {
                Console.WriteLine("Car Pulled Out Successfully");
                return;
            }
            Console.WriteLine("Error Occured");
        }
    }

    class Bike : IVehicle
    {
        IParkingSpace BikeParkingSpace;
        private string _BikeName;
        public string BikeName
        {
            get
            {
                return _BikeName;
            }
        }
        public Bike(string bikeName)
        {
            _BikeName = bikeName;
            BikeParkingSpace = new BikeParkingSpace();
        }
        public void ParkVehicle()
        {
            if (BikeParkingSpace.IsAlreadyParked(BikeName))
            {
                Console.WriteLine("Bike Already Parked");
                return;
            }

            bool IsSpaceAvailiable = BikeParkingSpace.isSpaceAvailiable();
            if (IsSpaceAvailiable)
            {
                bool IsSpaceUpdated = BikeParkingSpace.UpdateParkingSpace(true,BikeName);
                if (IsSpaceUpdated)
                {
                    Console.WriteLine("Bike Parked Successfully...");
                    return;
                }
                Console.WriteLine("Error Occured");
            }
            else
            {
                Console.WriteLine("No Space Availiable To Park the Vehicle");
            }
        }

        public void PullingOutVehicle()
        {
            if (!BikeParkingSpace.IsAlreadyParked(BikeName))
            {
                Console.WriteLine("Bike is Not Parked Anywhere");
                return;
            }

            bool IsSpaceUpdated = BikeParkingSpace.UpdateParkingSpace(false,BikeName);
            if (IsSpaceUpdated)
            {
                Console.WriteLine("Bike Pulled Out Successfully");
                return;
            }
            Console.WriteLine("Error Occured");
        }
    }
}
