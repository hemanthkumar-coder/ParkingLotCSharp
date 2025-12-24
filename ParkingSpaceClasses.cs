using ParkingLotApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.ParkingSpaceClasses
{
    public class CarParkingSpace : IParkingSpace
    {
        private static Dictionary<int, string> CarSpaceMap = new Dictionary<int, string>();
        static CarParkingSpace()
        {
            for(int i = 0; i < 10; i++)
            {
                CarSpaceMap.Add(i, "Availiable");
            }
        }
        public CarParkingSpace()
        {
            
        }
        public bool isSpaceAvailiable()
        {
            foreach(KeyValuePair<int,string> K in CarSpaceMap)
            {
                if (K.Value.Equals("Availiable"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateParkingSpace(bool isParking,string carName)
        {
            if (isParking)
            {
                foreach (KeyValuePair<int, string> K in CarSpaceMap)
                {
                    if (K.Value.Equals("Availiable"))
                    {
                        CarSpaceMap[K.Key] = carName;
                        return true;
                    }
                }
            }
            else
            {
                
                foreach (var item in CarSpaceMap)
                {
                    if (item.Value.Equals(carName))
                    {
                        CarSpaceMap[item.Key] = "Availiable";
                        return true;
                    }
                }
                
            }
                return false;
           
        }
        public bool IsAlreadyParked(string carName)
        {
            foreach (var item in CarSpaceMap)
            {
                if (item.Value.Equals(carName))
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class BikeParkingSpace : IParkingSpace
    {
        private static Dictionary<int, string> BikeSpaceMap = new Dictionary<int, string>();
        static BikeParkingSpace()
        {
            for (int i = 0; i < 10; i++)
            {
                BikeSpaceMap.Add(i, "Availiable");
            }
        }

        public BikeParkingSpace()
        {
            
        }

        public bool isSpaceAvailiable()
        {
            foreach (KeyValuePair<int, string> K in BikeSpaceMap)
            {
                if (K.Value.Equals("Availiable"))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsAlreadyParked(string bikeName)
        {
            foreach (var item in BikeSpaceMap)
            {
                if (item.Value.Equals(bikeName))
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateParkingSpace(bool isParking,string bikeName)
        {
            if (isParking)
            {
                foreach (KeyValuePair<int, string> K in BikeSpaceMap)
                {
                    if (K.Value.Equals("Availiable"))
                    {
                        BikeSpaceMap[K.Key] = bikeName;
                        return true;
                    }
                }
            }
            else
            {
                foreach (var item in BikeSpaceMap)
                {
                    if (item.Value.Equals(bikeName))
                    {
                        BikeSpaceMap[item.Key] = "Availiable";
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
