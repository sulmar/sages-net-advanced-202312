using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AttributeBasedProgramming;

internal class Base : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;


    // Przykład atrybutu na poziomie parametru metody
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        Console.WriteLine(propertyName);
    }
}

[Image("customer.png")]
[DisplayName("Klient")]
internal class Customer : Base
{
    [Required, MinLength(3, ErrorMessage = "Imię zbyt krótkie")]
    public string FirstName { get; set; }

    [Image("lastname.png")]
    public string LastName { get; set; }

    private string pesel;
    public string Pesel
    {
        get
        {
            return pesel;
        }
        set
        {
            pesel = value;

            OnPropertyChanged();
        }
    }

    public Gender Gender { get; set; }

    [ReadOnly]
    public bool IsRegonValid { get; set; }
    [ReadOnly]
    public bool IsPeselValid { get; set; }
    [ReadOnly(false)]
    public bool HasWebsite { get; set; }

    public void DoWork()
    {
        throw new NotImplementedException();
    }
}


public enum Gender
{
    [Image("male.png"), Description("Mężczyzna")]    
    Male,

    [Image("female.png", 0.8f)]
    [Description("Kobieta")]
    Female
}


