

using ParkingLotApp.ConsoleHelper;
using ParkingLotApp.Interfaces;
using ParkingLotApp.ParkingSpaceClasses;
using ParkingLotApp.ParkingVehicleClasses;

namespace ParkingLotApp
{
    class MainClass
    {
        public static void Main()
        {

            
            

            while (true)
            {
                Console.WriteLine("=========Welcome to Parking Lot=========");
                Console.WriteLine("=========Enter Your Choice=========");
                Console.WriteLine("1.Park Your Vehicle");
                Console.WriteLine("2.Pullout Your Vehicle");
                Console.WriteLine("3.Exit");
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
                        ConsoleHelperClass.ParkVehicle();
                        
                        break;
                    case 2:
                        ConsoleHelperClass.PulloutVehicle();
                        break;
                    case 3:
                        Console.WriteLine("=========Exited From App Successfully=========");
                        return;

                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
            }


        }
    }
}