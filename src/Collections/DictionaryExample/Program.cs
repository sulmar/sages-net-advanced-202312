

using DictionaryExample;

Console.WriteLine("Hello, Dictionary!");

VehicleServiceTest();

void VehicleServiceTest()
{
    VehicleService vehicleService = new VehicleService();

    // Simulate of vehicles
    List<Vehicle> vehiclesToAdd = new List<Vehicle>();
    for (int i = 1; i <= 1000; i++)
    {
        Vehicle vehicle = new Vehicle($"ABC{i}", $"Customer{i}");
        vehiclesToAdd.Add(vehicle);
    }

    while (true)
    {
        Console.WriteLine("plateNumber: ");
        string? plateNumberToFind = Console.ReadLine();

        Vehicle? vehicle = vehicleService.GetByPlateNumber(plateNumberToFind);

        Console.WriteLine(vehicle.CustomerName);
    }
}