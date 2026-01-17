using ParkingSpotDesign.Enums;

namespace ParkingSpotDesign.Modal
{
    public class ParkingSpot
    {
        public string SpotId { get; set; }
        public SpotType SpotType { get; set; }
        public bool isAvailable { get; set; }
        public void Occupy()
        {
            isAvailable = true;
        }
        public void Vacate()
        {
            isAvailable = false;
        }

    }
}
