

Console.WriteLine("Hello, PLINQ!");

// https://learn.microsoft.com/pl-pl/dotnet/standard/parallel-programming/introduction-to-plinq

Console.WriteLine("LINQ");

var result = "abcdef".ToCharArray()
    .Select(c => char.ToUpper(c));

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.WriteLine("Parallel LINQ");

var source = Enumerable.Range(1, 10000);
var query = from item in source.AsParallel().WithDegreeOfParallelism(2)
            where Compute(item) > 42
            select item;

foreach (var item in query)
{
    Console.WriteLine(item);
}


Console.ReadKey();


int Compute(int item)
{
   
    Thread.Sleep(100);
   
    Console.Write(".");

    return item;
}


return;

while (true)

{
    "abcdef".AsParallel()
        .Select(item => char.ToUpper(item))
        .ForAll(item => Console.WriteLine(item));


    Console.WriteLine("---");

    Thread.Sleep(1000);

}
