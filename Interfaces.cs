

namespace ParkingLotApp.Interfaces
{
    public interface IParkingSpace
    {
         bool isSpaceAvailiable();
        bool UpdateParkingSpace(bool isParking,string vehicleName);

        bool IsAlreadyParked(string vehicleName);
    }

    interface IVehicle
    {
        void ParkVehicle();
        void PullingOutVehicle();
    }
}
