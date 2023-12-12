using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Fakers;

public class CustomerFaker : Faker<Customer>
{
    public CustomerFaker()
    {
        RuleFor(p => p.Id, f => f.IndexFaker);
        RuleFor(p => p.FirstName, f => f.Person.FirstName);
        RuleFor(p => p.LastName, f => f.Person.LastName);
        RuleFor(p => p.Email, (f, customer) => $"{customer.FirstName}.{customer.LastName}@domain.com"); // {firstname}.{lastname}@domain.com;
        RuleFor(p => p.Address, f => f.Address.StreetAddress());
        RuleFor(p => p.City, f => f.Address.City());
        RuleFor(p => p.HashedPassword, f => f.Lorem.Word());
        RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.3f));
    }
}
