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
        private bool isAlreadyParked;
        public Car()
        {
            this.CarParkingSpace = new CarParkingSpace();
            isAlreadyParked = false;
        }
        public void ParkVehicle()
        {
            if (isAlreadyParked)
            {
                Console.WriteLine("Vehicle Already Parked");
                return;
            }

            bool IsSpaceAvailiable = CarParkingSpace.isSpaceAvailiable();
            if (IsSpaceAvailiable)
            {
                bool IsSpaceUpdated = CarParkingSpace.UpdateParkingSpace(true);
                if (IsSpaceUpdated)
                {
                    isAlreadyParked = true;
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
            if (!isAlreadyParked)
            {
                Console.WriteLine("Your vehicle Not Parked Anywhere");
                return;
            }

            bool IsSpaceUpdated = CarParkingSpace.UpdateParkingSpace(false);
            if (IsSpaceUpdated)
            {
                isAlreadyParked = false;
                Console.WriteLine("Car Pulled Out Successfully");
                return;
            }
            Console.WriteLine("Error Occured");
        }
    }

    class Bike : IVehicle
    {
        IParkingSpace BikeParkingSpace;
        private bool isAlreayParked;
        public Bike()
        {
            BikeParkingSpace = new BikeParkingSpace();
            isAlreayParked = false;
        }
        public void ParkVehicle()
        {
            if (isAlreayParked)
            {
                Console.WriteLine("Bike Already Parked");
                return;
            }

            bool IsSpaceAvailiable = BikeParkingSpace.isSpaceAvailiable();
            if (IsSpaceAvailiable)
            {
                bool IsSpaceUpdated = BikeParkingSpace.UpdateParkingSpace(true);
                if (IsSpaceUpdated)
                {
                    isAlreayParked = true;
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
            if (!isAlreayParked)
            {
                Console.WriteLine("Vehicle is Not Parked Anywhere");
                return;
            }

            bool IsSpaceUpdated = BikeParkingSpace.UpdateParkingSpace(false);
            if (IsSpaceUpdated)
            {
                isAlreayParked = false;
                Console.WriteLine("Car Pulled Out Successfully");
                return;
            }
            Console.WriteLine("Error Occured");
        }
    }
}
