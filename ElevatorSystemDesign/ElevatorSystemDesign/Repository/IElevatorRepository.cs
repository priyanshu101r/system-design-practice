using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.ElevatorRepository
{
    public interface IElevatorRepository
    {
        List<Elevator> GetAall();
        Elevator GetById(string id);
        void Update(Elevator elevator);

    }
}
