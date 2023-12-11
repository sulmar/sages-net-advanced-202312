using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure
{
    public class InMemoryCustomerRepository : InMemoryEntityRepository<Customer>, ICustomerRepository
    {

    }

    
}
