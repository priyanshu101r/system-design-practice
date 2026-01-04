using CarRentalSystem.Enums;

namespace CarRentalSystem.Models
{
    public class Vichle
    {
        public string VichleNo { get; set; }
        public VichleType VichleType { get; set; }
        public bool IsInsurance { get; set; }
        public VehicleStatus VehicleStatus { get; set; }
    }
}
