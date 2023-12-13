namespace AttributeBasedProgramming;

[AttributeUsage(AttributeTargets.Property)]
public class ReadOnlyAttribute : Attribute
{
    public bool IsReadOnly { get; private set; }    

    public ReadOnlyAttribute(bool isReadOnly = true) 
    { 
        this.IsReadOnly = isReadOnly;
    }
}