namespace BlazorApp.Model;


public abstract class Base
{

}

public abstract class BaseEntity : Base
{
    public int Id { get; set; }
}

public class Customer : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
