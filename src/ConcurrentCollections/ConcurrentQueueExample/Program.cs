
using ConcurrentQueueExample;

Console.WriteLine("Hello, ConcurrentQueue!");
TaskManager taskManager = new TaskManager();

// Start task processing in the background
taskManager.ProcessTasks();

// Simulate multiple threads enqueuing tasks concurrently without proper synchronization
Parallel.Invoke(
    () => taskManager.EnqueueTask("Task 1"),
    () => taskManager.EnqueueTask("Task 2"),
    () => taskManager.EnqueueTask("Task 3")
);

// Simulate the main thread doing some work
Console.WriteLine("Main thread is working...");

// Keep the application running
Console.ReadLine();