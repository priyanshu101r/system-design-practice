using ParkingSpotDesign.Enums;

namespace ParkingSpotDesign.Modal
{
    public class HeavyVichle : Vichle
    {
        public int? wait { get; set; }
        public HeavyVichle(string vichleNo, int? wait) : base(vichleNo, VichleType.twowheeler)
        {
            this.wait = wait;
        }

        public override void ValidateEntry()
        {
            if (wait > 10000)
            {
                throw new InvalidOperationException("Heavy vehicle exceeds allowed weight");
            }
        }
    }
}
