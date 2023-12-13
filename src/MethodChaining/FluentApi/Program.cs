
using FluentApi;

Console.WriteLine("Hello, Method Chaining!");

// Zastosowanie
// Fluent Regex
// https://github.com/VerbalExpressions/CSharpVerbalExpressions

// Fluent Docker
// https://github.com/mariotoffia/FluentDocker
// https://dotnet.testcontainers.org/


//Phone phone = new Phone();
//phone.Call("John", "Kate", ".NET");

string[] recipients = new string[] { "a", "b" };

//FluentPhone.Hangup()
//    .From("a").To("b").To("c").To("d").WithSubject("lorem").Call();

FluentPhone
    .Hangup()
    .From("John")
    .To(recipients)
    .To("Bob")
    .To("Jack")
    .WithSubject(".NET")
    // .HighPrority
    .Call();


// FluentPhone.From("John").To("Kate").WithSubject(".NET");