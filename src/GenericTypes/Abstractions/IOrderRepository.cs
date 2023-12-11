using GenericTypes.Model;

namespace GenericTypes.Abstractions;

public interface IOrderRepository : IEntityRepository<Order, long>
{

}
