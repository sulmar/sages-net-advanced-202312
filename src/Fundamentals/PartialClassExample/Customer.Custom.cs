using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample;

public partial class Customer
{
    public bool IsSelected { get; set; }

    public void DoWork()
    {
        throw new NotImplementedException();
    }

    public decimal CalculateSalary()
    {
        throw new NotImplementedException();
    }
}
