

namespace ParkingLotApp.Interfaces
{
    public interface IParkingSpace
    {
         bool isSpaceAvailiable();
        bool UpdateParkingSpace(bool isParking);
    }

    interface IVehicle
    {
        void ParkVehicle();
        void PullingOutVehicle();
    }
}
