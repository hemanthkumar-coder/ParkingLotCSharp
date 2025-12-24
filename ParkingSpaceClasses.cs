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
        private static List<int> CarSpaceList = new List<int>() { 0,1,1,1,1};
        public CarParkingSpace()
        {
            
        }
        public bool isSpaceAvailiable()
        {
            foreach (var item in CarSpaceList)
            {
                if (item == 0) return true;
            }
            return false;
        }

        public bool UpdateParkingSpace(bool isParking)
        {
            for(int i = 0; i < CarSpaceList.Count; i++)
            {
                if (CarSpaceList[i]==0&&isParking)
                {
                    CarSpaceList[i] = 1;
                    return true;
                }else if (CarSpaceList[i] == 1 && !isParking)
                {
                    CarSpaceList[i] = 0;
                    return true;
                }
            }
            return false;
        }
    }

    public class BikeParkingSpace : IParkingSpace
    {
       private static List<int> BikeParkingSpaceList = new List<int>()
            {
                1,0,1,1,0,1
            };
        public BikeParkingSpace()
        {
            
        }

        public bool isSpaceAvailiable()
        {
            foreach (var item in BikeParkingSpaceList)
            {
                if (item == 0) return true;   
            }
            return false;
        }

        public bool UpdateParkingSpace(bool isParking)
        {
            for (int i = 0; i < BikeParkingSpaceList.Count; i++)
            {
                if (BikeParkingSpaceList[i] == 0 && isParking)
                {
                    BikeParkingSpaceList[i] = 1;
                    return true;
                }else if(BikeParkingSpaceList[i] == 1 && !isParking)
                {
                    BikeParkingSpaceList[i] = 0;
                    return true;
                }
            }
            return false;
        }
    }
}
