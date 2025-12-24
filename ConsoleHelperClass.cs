using ParkingLotApp.Interfaces;
using ParkingLotApp.ParkingVehicleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.ConsoleHelper
{
    class ConsoleHelperClass
    {
        public static void ParkVehicle()
        {
            Console.WriteLine("=========Select Vehicle Type=========");
            Console.WriteLine("1.Car\n2.Bike");
            int choice;
            try{
                choice = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Enter Valid Choice");
                choice = int.Parse(Console.ReadLine());
            }
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("=========Enter Car Name=========");
                    string carName = Console.ReadLine();
                    if (carName.Equals("") || carName.Equals(null))
                    {
                        Console.WriteLine("Enter Valid CarName");
                        carName = Console.ReadLine();
                    }
                    IVehicle car = new Car(carName);
                    Console.Clear();
                    car.ParkVehicle();
                    return;
                case 2:
                    Console.WriteLine("=========Enter Bike Name=========");
                    string bikeName = Console.ReadLine();
                    if (bikeName.Equals("") || bikeName.Equals(null))
                    {
                        Console.WriteLine("Enter Valid CarName");
                        carName = Console.ReadLine();
                    }
                    IVehicle bike = new Bike(bikeName);
                    Console.Clear();
                    bike.ParkVehicle();
                    return;
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            

        }
        public static void PulloutVehicle()
        {
            Console.WriteLine("=========Select Vehicle Type=========");
            Console.WriteLine("1.Car\n2.Bike");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter Valid Choice");
                choice = int.Parse(Console.ReadLine());
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("=========Enter Car Name=========");
                    string carName = Console.ReadLine();
                    if (carName.Equals("") || carName.Equals(null))
                    {
                        Console.WriteLine("Enter Valid CarName");
                        carName = Console.ReadLine();
                    }
                    IVehicle car = new Car(carName);
                    Console.Clear();
                    car.PullingOutVehicle();
                    return;
                case 2:
                    Console.WriteLine("=========Enter Bike Name=========");
                    string bikeName = Console.ReadLine();
                    if (bikeName.Equals("") || bikeName.Equals(null))
                    {
                        Console.WriteLine("Enter Valid CarName");
                        carName = Console.ReadLine();
                    }
                    IVehicle bike = new Bike(bikeName);
                    Console.Clear();
                    bike.PullingOutVehicle();
                    return;
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }


        }
    }
}
