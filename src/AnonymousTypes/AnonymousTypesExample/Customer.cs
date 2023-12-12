namespace AnonymousTypesExample;

internal class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string HashedPassword { get; set; }
    public bool IsRemoved { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {Email} {IsRemoved}";
    }
}

internal class CustomerInfo
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string City { get; private set; }

    public CustomerInfo(Customer customer)
    {
        this.FirstName = customer.FirstName;
        this.LastName = customer.LastName;
        this.City = customer.City;
    }
}

internal class CustomerInfo2
{
    public string Email { get; set; }
    public bool IsRemoved { get; set; }

    public CustomerInfo2(Customer customer)
    {
        this.Email = customer.Email;
        this.IsRemoved = customer.IsRemoved;
    }
}
