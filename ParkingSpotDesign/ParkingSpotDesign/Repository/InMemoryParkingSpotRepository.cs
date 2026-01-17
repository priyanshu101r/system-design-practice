using ParkingSpotDesign.Enums;
using ParkingSpotDesign.Modal;

namespace ParkingSpotDesign.Repository
{
    public class InMemoryParkingSpotRepository : IParkingSpotRepository
    {
        private readonly List<ParkingSpot> _spots = new()
            {
                new ParkingSpot{ SpotId = "T1",SpotType = SpotType.TwoWheeler },
                new ParkingSpot{SpotId = "T1",SpotType = SpotType.TwoWheeler },
                new ParkingSpot{SpotId = "F1", SpotType = SpotType.FourWheeler },
                new ParkingSpot{SpotId = "F2", SpotType = SpotType.FourWheeler },
            };

        public void AddSpot(ParkingSpot spot)
        {
            _spots.Add(spot);
        }

        public List<ParkingSpot> GetALL()
        {
            return _spots;
        }


        public void RemoveSpot(string spotId)
        {
            _spots.RemoveAll(s => s.SpotId == spotId);
        }
    }
}
