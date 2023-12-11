using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure
{
    public class InMemoryOrderRepository : InMemoryEntityRepository<Order>, IOrderRepository
    {
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Order Get(long id)
        {
            throw new NotImplementedException();
        }
    }

    
}
