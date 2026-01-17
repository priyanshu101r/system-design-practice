using ElevatorSystemDesign.Controller;
using ElevatorSystemDesign.ElevatorRepository;
using ElevatorSystemDesign.Schedular;

namespace ElevatorSystemDesign.Factory
{
    public class ElevatorSystemFactory
    {
        public static IElevatorSystem Create()
        {
            IElevatorRepository repos = new ElevatorRepository.ElevatorRepository();
            IScheduler scheduler = new NormalScheduler(repos);
            Dispatcher dispatcher1 = new Dispatcher(scheduler, repos);
            ElevatorController controller = new ElevatorController(dispatcher1);
            return new ElevatorSystem(controller);
        }


    }
}
