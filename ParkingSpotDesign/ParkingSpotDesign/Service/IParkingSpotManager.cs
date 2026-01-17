using ParkingSpotDesign.Enums;
using ParkingSpotDesign.Modal;

namespace ParkingSpotDesign.Service
{
    public interface IParkingSpotManager
    {
        ParkingSpot AssignSpot(VichleType type);
        void ReleaseSpot(string spotId);
        void AddSpot(ParkingSpot parkingSpot);
        bool isSpotAvailable(VichleType parkingSpot);
        void RemoveSpot(string SpotId);
    }
}
