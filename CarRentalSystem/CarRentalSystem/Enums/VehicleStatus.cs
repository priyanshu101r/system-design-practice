namespace CarRentalSystem.Enums
{
    public enum VehicleStatus
    {
        Available,        // Can be booked right now
        Reserved,         // Booked for a future time
        Booked,           // Currently in use
        Maintenance,      // Not usable
        Inactive          // Disabled / removed from service
    }
}
