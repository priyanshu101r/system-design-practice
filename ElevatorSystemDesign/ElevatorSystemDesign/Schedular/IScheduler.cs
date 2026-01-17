using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.Schedular
{
    public interface IScheduler
    {
        public Elevator GetBestElevator(SearchElevator searchObj);
    }
}
