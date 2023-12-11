namespace GenericTypes;

class Factory
{
    public static object Create(Type type)
    {
        throw new NotImplementedException();
    }

    public static T Create<T>()
        where T : class, new() // reguła - wymagamy aby typ posiadać bezparametryczny konstruktor
    {

        return new T();
    }
}
