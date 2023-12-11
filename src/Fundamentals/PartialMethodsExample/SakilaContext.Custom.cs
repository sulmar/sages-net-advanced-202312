using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodsExample;


internal partial class SakilaContext
{
    partial void CustomOnModelCreating(ModelBuilder modelBuilder)
    {
         // Custom code
    }
}
