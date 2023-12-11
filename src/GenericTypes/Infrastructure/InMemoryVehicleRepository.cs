using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure
{
    public class InMemoryVehicleRepository : InMemoryEntityRepository<Vehicle>, IVehicleRepository
    {
        public Vehicle? GetByPlateNumber(string plateNumber)
        {
            return entities.Values.SingleOrDefault(e=>e.PlateNumber == plateNumber);
        }
    }

    
}
