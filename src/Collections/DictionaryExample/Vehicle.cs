namespace DictionaryExample;

class Vehicle
{
    public string PlateNumber { get; }
    public string CustomerName { get; }

    public Vehicle(string plateNumber, string customerName)
    {
        PlateNumber = plateNumber;
        CustomerName = customerName;
    }

    public override string ToString()
    {
        return $"Vehicle - Plate Number: {PlateNumber}, Customer Name: {CustomerName}";
    }
}