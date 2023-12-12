using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample;

internal class VehicleService
{
    private IDictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

    public void Add(Vehicle vehicle)
    {
        vehicles.Add(vehicle.PlateNumber, vehicle); 
    }

    public void AddRange(IEnumerable<Vehicle> items)
    {
        vehicles = items.ToDictionary(item => item.PlateNumber);
    }

    public Vehicle GetByPlateNumber(string plateNumber)
    {
        if (vehicles.TryGetValue(plateNumber, out Vehicle vehicle))
        {
            return vehicle;
        }
        else
        {
            return null;
        }
    }
}
