using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.ElevatorRepository
{
    public class ElevatorRepository : IElevatorRepository
    {
        private List<Elevator> _elevators = new List<Elevator> {
         new Elevator{Id="E1",Status = Enums.Status.IDLE },
         new Elevator{Id="E2",Status = Enums.Status.IDLE },
         new Elevator{Id="E3",Status = Enums.Status.IDLE },
         new Elevator{Id="E4",Status = Enums.Status.IDLE },
         new Elevator{Id="E5",Status = Enums.Status.IDLE },
        };

        public List<Elevator> GetAall()
        {
            return _elevators;
        }

        public Elevator GetById(string id)
        {
            return _elevators.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Elevator elevator)
        {
            var el = _elevators.Where(_elevators => _elevators.Id == elevator.Id).FirstOrDefault();
            el = elevator;

        }
    }
}
