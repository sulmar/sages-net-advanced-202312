using ConcurrentBagExample;

Console.WriteLine("Hello, ConcurrentBag!");

LogManager logManager = new LogManager();

// Start log processing in the background
logManager.ProcessLogs();

// Simulate multiple threads adding log entries concurrently
Parallel.Invoke(
    () => logManager.Log("Error in Module A"),
    () => logManager.Log("Warning in Module B"),
    () => logManager.Log("Info in Module C")
);

// Simulate the main thread doing some work
Console.WriteLine("Main thread is working...");

// Keep the application running
Console.ReadLine();