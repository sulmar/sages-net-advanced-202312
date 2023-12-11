using GenericTypes.Model;

namespace GenericTypes.Abstractions;

// Interfejsy generyczne (ugólnione)
// Szablon
public interface IEntityRepository<T, TKey>
    where T : BaseEntity   //                               - ograniczamy zbiór typów do typów pochodnych po wskazanej typie
    // where T : class     // constraints (reguły) - class  - ograniczamy zbiór typów do typów referencyjnych
    where TKey : struct    // constraints (reguły) - struct - ograniczamy zbiór typów do typów wartościowych
{
    IEnumerable<T> GetAll();
    T Get(TKey id);
    void Add(T entity);
    void Update(T entity);
    void Delete(TKey id);
}


public interface IEntityRepository<T> : IEntityRepository<T, int>
    where T : BaseEntity
{

}
