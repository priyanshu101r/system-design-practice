using ParkingSpotDesign.Modal;

namespace ParkingSpotDesign.Repository
{
    public interface IParkingSpotRepository
    {
        public List<ParkingSpot> GetALL();
        public void RemoveSpot(string spotId);
        public void AddSpot(ParkingSpot spot);
    }
}
