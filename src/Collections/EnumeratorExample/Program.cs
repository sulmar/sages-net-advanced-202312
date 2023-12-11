
using EnumeratorExample;

Console.WriteLine("Hello, Enumerator!");

IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

// var enumerator = numbers.GetEnumerator();

// var enumerator = numbers.GetMyNumerator();

var enumerator = new MyEnumerator(numbers.ToArray());

foreach (int number in enumerator)
{
    Console.WriteLine(number);
}


while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}


var data = new List<string> { "One", "Two", "Three" };

var dataEnumerator = new CircularEnumerator<string>(data.GetEnumerator());

while(dataEnumerator.MoveNext())
{
    Console.WriteLine(dataEnumerator.Current);
}

foreach(var item in dataEnumerator)
{
    Console.WriteLine(item);
}
