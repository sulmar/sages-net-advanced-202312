using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Base
    {

    }

    internal class Vehicle
    {
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    internal class Customer : Base, INotifyPropertyChanged
    {
        private bool isRemoved;
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public bool IsRegonValid { get; set; }
        public bool IsPeselValid { get; set; }
        public bool HasWebsite { get; set; }


        public decimal Balance { get; set; }

        public void Remove()
        {
            if (Balance == 0) 
                isRemoved = true;            
        }

        public object this[string propertyName]
        {
            get => GetType().GetProperty(propertyName).GetValue(this);
            set => GetType().GetProperty(propertyName).SetValue(this, value);
        }
    }
}
