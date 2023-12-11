using System.ComponentModel;

namespace PartialMethodsExample
{
    class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            throw new NotImplementedException();
        }
    }

    internal partial class Customer : Base
    {
        private string firstName;

        public int Id { get; set; }
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
            }
        }

        private string pesel;

        public string Pesel
        {
            get { return pesel; }
            set
            {
                Validate(value);

                OnPropertyChanging(nameof(Pesel));

                pesel = value;

                OnPropertyChanged(nameof(Pesel));

            }
        }

        partial void Validate(string pesel);
        partial void OnPropertyChanging(string propertyName);
        partial void OnPropertyChanged(string propertyName);

    }
}
