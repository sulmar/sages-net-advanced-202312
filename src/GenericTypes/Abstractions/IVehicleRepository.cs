using GenericTypes.Model;

namespace GenericTypes.Abstractions;

public interface IVehicleRepository : IEntityRepository<Vehicle>
{
    Vehicle? GetByPlateNumber(string plateNumber);
}
