using ParkingSpotDesign.Enums;
using ParkingSpotDesign.Modal;

namespace ParkingSpotDesign.Factory
{
    public class VehicleFactory
    {
        public object GetVichleInstance(string vichleNo, VichleType type, int? wieght = null)
        {
            switch (type)
            {
                case VichleType.twowheeler:
                    return new TwoWheeler(vichleNo);
                case VichleType.fourwheeler:
                    return new Modal.FourWheeler(vichleNo);
                case VichleType.HeavyVehicle:
                    return new HeavyVichle(vichleNo, wieght);
                default:
                    return null;
            }
        }
    }
}
