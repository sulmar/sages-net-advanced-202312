

using System;
using System.Threading.Channels;
using TaskExample;

Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Hello, Task!");

// ReflectionTaskTest();

CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(20));


CancellationToken cancellationToken = cancellationTokenSource.Token;

IProgress<int> progress = new Progress<int>(step => Console.Write("."));

TaxCalculator taxCalculator = new TaxCalculator();

Task<decimal> task1 = Task.Run(() => taxCalculator.Calculate(1000, cancellationToken, progress));
Task<decimal> task2 = Task.Run(() => taxCalculator.Calculate(1000, cancellationToken, progress));

// Czekamy na wykonanie zadań i idziemy dalej
//Task.WaitAll(task1, task2);
// var total = task1.Result + task2.Result;

// Wykonaj sumowanie po zakończeniu wszystkich zadań, ale nie czekaj
Task.WhenAll(task1, task2)
    .ContinueWith(completedTasks => Console.WriteLine($"Total {completedTasks.Result[0] + completedTasks.Result[1]}"));
    

Task<decimal> task = Task.Run(() => taxCalculator.Calculate(1000, cancellationToken, progress));

// Method Chaining 
Task continuationTask = task
    .ContinueWith(completedTask => Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} {completedTask.Result}"))
        .ContinueWith(nextCompletedTask => Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} next job"));


Console.WriteLine("Press Enter to cancel task");

Console.ReadLine();

// cancellationTokenSource.Cancel();

cancellationTokenSource.CancelAfter(3000);

Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Press any key to exit.");
Console.ReadLine();

// task.Wait();

// Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} {task.Result}");

// Console.WriteLine("..");

// TaskTest();

// TaskWithResult();

void TaskWithResult()
{
    // Action -> void
    // Func<>
    // Func<bool> = Predicate

    var calculate = () =>
    {
        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task is running...");

        Thread.Sleep(2000);

        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task completed.");

        return 100;
    };

    Task<int> task = Task.Run(calculate);

    Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task created and started.");

    Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task started. Waiting for completion...");

    task.Wait();

    Console.WriteLine($"Task Result: {task.Result}");


}


static void TaskTest()
{
    var doWork = () =>
    {
        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task is running...");

        Thread.Sleep(2000);

        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task completed.");
    };

    // Thread thread = new Thread(doWork);

    // Utworzenie zadania
    // Task task = new Task(() => Send("a"));

    // Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task created.");


    // thread.Start();

    // Uruchomienie zadania
    // task.Start(); 

    // Utwórz i uruchom zadanie
    Task task = Task.Run(() => Send("a"));

    Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task created and started.");

    Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task started. Waiting for completion...");

    // thread.Join()
    task.Wait();
}


static void Send(string email)
{
    Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task is running... {email}");

    Thread.Sleep(2000);

    Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Task completed. {email}");

}

static void ReflectionTaskTest()
{
    var settings = new { FirstAction = "Move", NextAction = "Rotate" };

    var action1 = ActionHelper.FromMethodName<Printer>(settings.FirstAction);
    var action2 = ActionHelper.FromMethodName<Printer>(settings.NextAction);

    Task rootTask = Task.Run(action1)
        .ContinueWith(completedTask => action2);
}