using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure
{
    // Klasa generyczna (uogólniona)
    // Szablon klasy
    public abstract class InMemoryEntityRepository<T> : IEntityRepository<T>
        where T : BaseEntity
    {
        protected readonly IDictionary<int, T> entities = new Dictionary<int, T>();

        public void Add(T entity)
        {
            entities.Add(entity.Id, entity);
        }

        public void Delete(int id)
        {
            entities.Remove(id);
        }

        public T Get(int id)
        {
            if (entities.TryGetValue(id, out T entity))
                return entity;
            else
                return default;
        }

        public IEnumerable<T> GetAll()
        {
            return entities.Values;
        }

        public void Update(T entity)
        {
            entities[entity.Id] = entity;
        }
    }

    
}
