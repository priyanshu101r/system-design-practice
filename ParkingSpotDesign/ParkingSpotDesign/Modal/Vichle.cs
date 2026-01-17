using ParkingSpotDesign.Enums;

namespace ParkingSpotDesign.Modal
{
    public abstract class Vichle
    {
        public string VichleNo { get; set; }
        public VichleType VichleType { get; set; }
        public Vichle(string vichleNo, VichleType vichleType)
        {
            VichleNo = vichleNo;
            VichleType = vichleType;
        }

        public virtual void ValidateEntry()
        {
            // Common validation logic for all vehicles can be added here
        }
    }
}
