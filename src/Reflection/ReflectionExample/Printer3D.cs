using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample;

public class Printer3D
{
    public Position3D CurrentPosition { get; set; }

    public Printer3D()
    {
        CurrentPosition = new Position3D(0, 0, 0);
    }

    public void Move()
    {
        Console.WriteLine("Move");
    }

    public void Rotate()
    {
        Console.WriteLine("Rotate");
    }

    public void Up()
    {
        throw new NotImplementedException();
    }

    public void Down()
    {
        throw new NotImplementedException();
    }

    private void Alarm()
    {
        Console.WriteLine("Alarm");
    }

}

public class Position3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Position3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

   
}

interface ICommand
{
    void Execute();
}

internal class MoveCommand : ICommand
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Execute()
    {
        Console.WriteLine("Moved");
    }
}

internal class RotateCommand : ICommand
{
    public int Angle { get; set; }

    public void Execute()
    {
        Console.WriteLine("Rotated");
    }
}

internal class UpCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Up");
    }
}

internal class DownCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Down");
    }
}

internal class DrillCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Drill");
    }
}
