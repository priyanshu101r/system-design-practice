using ParkingSpotDesign.Enums;
using ParkingSpotDesign.Modal;
using ParkingSpotDesign.Repository;

namespace ParkingSpotDesign.Service
{
    public class ParkingSpotManager : IParkingSpotManager
    {
        public IParkingSpotRepository _parkingSpotRepository;
        public ParkingSpotManager(IParkingSpotRepository parkingSpotRepository)
        {
            _parkingSpotRepository = parkingSpotRepository;
        }
        public void AddSpot(ParkingSpot parkingSpot)
        {
            _parkingSpotRepository.AddSpot(parkingSpot);
        }

        public ParkingSpot AssignSpot(VichleType type)
        {
            var spotType = MapVehicleToSpot(type);
            var spot = _parkingSpotRepository.GetALL().Where(x => x.SpotType == spotType && !x.isAvailable).FirstOrDefault();
            spot.Occupy();
            return spot;
        }

        public bool isSpotAvailable(VichleType type)
        {
            var spotType = MapVehicleToSpot(type);
            return _parkingSpotRepository.GetALL()
                .Any(s => s.SpotType == spotType && !s.isAvailable);

        }

        public void ReleaseSpot(string spotId)
        {
            var spot = _parkingSpotRepository.GetALL().Where(x => x.SpotId == spotId).FirstOrDefault();
            spot.Vacate();
        }

        public void RemoveSpot(string SpotId)
        {
            _parkingSpotRepository.RemoveSpot(SpotId);
        }
        private SpotType MapVehicleToSpot(VichleType type)
        {
            return type switch
            {
                VichleType.twowheeler => SpotType.TwoWheeler,
                VichleType.fourwheeler => SpotType.FourWheeler,
                _ => throw new ArgumentOutOfRangeException(nameof(type), "Unsupported vehicle type"),
            };
        }
    }
}
