using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public class VichleService : IVichleService
    {
        public List<Vichle> VichleList = new List<Vichle> {
            new Vichle { VichleNo = "UP14", IsInsurance = true, VichleType= Enums.VichleType.Car,},
            new Vichle { VichleNo = "UP15", IsInsurance = true, VichleType= Enums.VichleType.Car}

        };
        public void AddVichle(Vichle vichle)
        {
            VichleList.Add(vichle);
        }
        public void RemoveVichle(string vichleId)
        {
            var vichle = VichleList.Where(x => x.VichleNo == vichleId).FirstOrDefault();
            VichleList.Remove(vichle);

        }
        public Vichle GetVichleById(string vichleId)
        {
            return VichleList.Where(x => x.VichleNo == vichleId).FirstOrDefault();
        }
        public bool IsVichleAvailableForBook(string vichleId)
        {
            return VichleList.Any(x => x.VichleNo == vichleId && x.VehicleStatus == Enums.VehicleStatus.Available);
        }
    }
}
