using ElevatorSystemDesign.ElevatorRepository;
using ElevatorSystemDesign.Enums;
using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.Schedular
{
    public class Dispatcher
    {
        private IScheduler _currentScheduler;
        private IElevatorRepository elevatorRepository;
        public Dispatcher(IScheduler scheduler, IElevatorRepository elevatorRepository)
        {
            _currentScheduler = scheduler;
            this.elevatorRepository = elevatorRepository;
        }

        public void ChangeMode(ElevatorMode mode)
        {
            _currentScheduler = mode switch
            {
                ElevatorMode.Normal => new NormalScheduler(elevatorRepository),
                ElevatorMode.OddEven => new OddEvenScheduler(),
                ElevatorMode.Zone => new DozenSchedular(),
                _ => _currentScheduler
            };
        }
        public Elevator Dispatch(SearchElevator searchObj) => _currentScheduler.GetBestElevator(searchObj);
    }
}
