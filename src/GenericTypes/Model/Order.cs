namespace GenericTypes.Model;

public class Order : BaseEntity
{
    public string Number { get; set; }
    public decimal TotalAmount { get; set; }
}


