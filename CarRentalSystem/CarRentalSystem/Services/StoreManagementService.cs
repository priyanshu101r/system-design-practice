using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public class StoreManagementService : IStoreManagementService
    {
        private readonly IVichleService vichleService;
        private readonly IBookingService bookingService;

        public StoreManagementService(IVichleService vichleService, IBookingService bookingService)
        {
            this.vichleService = vichleService;
            this.bookingService = bookingService;
        }
        private List<Store> stores = new List<Store>()
        {
            new Store { StoreId = 1, Name="Delhi ZoomCar", Location="Delhi Shadhra", Company = new Company(){Name="Zoom Car private ltd"}, ContactNumber="8368731176" },
            new Store { StoreId = 2, Name="Jaipur ZoomCar", Location="Rajisthan JaiPur", Company = new Company(){Name="Zoom Car private ltd"}, ContactNumber="8368731176" }
        };
        public List<Store> GetAllStore()
        {
            return stores;
        }
        public Store GetStoreById(int storeId)
        {
            return stores.Where(x => x.StoreId == storeId).FirstOrDefault();
        }
        public void AddVichleToStore(int storeId, Vichle vichle)
        {
            var store = GetStoreById(storeId);
            if (store != null)
            {
                vichleService.AddVichle(vichle);
                if (store.Vichles == null)
                {
                    store.Vichles = new List<Vichle>();
                }
                store.Vichles.Add(vichle);
            }
        }


    }
}
