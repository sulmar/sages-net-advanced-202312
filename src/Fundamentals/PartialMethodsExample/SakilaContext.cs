using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodsExample;

class DbContext
{
    public DbContext()
    {
        OnModelCreating(new ModelBuilder());
    }

    protected virtual void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}

class ModelBuilder
{

}

// Generated code...
internal partial class SakilaContext : DbContext
{
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Generated code...
        Console.WriteLine("...");

        // "zaślepka" - w to miejsce zostanie umieszczony kod z metody częściowej jeśli zostanie zaimplementowana
        CustomOnModelCreating(modelBuilder);
    }

    // Metoda częściowa (Partial Method) - tylko sygnatura metody
    partial void CustomOnModelCreating(ModelBuilder modelBuilder);
   
}
