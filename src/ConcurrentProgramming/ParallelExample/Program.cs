
using System.Collections.Generic;

Console.WriteLine("Hello, Parallel!");

var numbers = Enumerable.Range(0, 10000).ToList();


Parallel.ForEach(numbers, number => Console.WriteLine(number));

