using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodsExample;

internal partial class Customer
{
    partial void Validate(string pesel)
    {
        if (pesel.Length != 11)
            throw new FormatException();
    }
}
