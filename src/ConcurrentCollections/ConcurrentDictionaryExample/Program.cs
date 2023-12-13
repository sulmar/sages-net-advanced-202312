
using ConcurrentDictionaryExample;

Console.WriteLine("Hello, ConcurrentDictionary!");


ConfigManager configManager = new ConfigManager();

// Simulate multiple threads setting and getting values concurrently
Parallel.Invoke(
    () => configManager.Set("Key1", "Value1"),
    () => configManager.Set("Key2", "Value2"),
    () => configManager.Set("Key3", "Value3"),
    () =>
    {
        // Simulate a delay before getting a value
        Task.Delay(100).Wait();
        var value = configManager.Get("Key2");
        Console.WriteLine($"Thread {Task.CurrentId} retrieved value: {value}");
    }
);

// Simulate the main thread doing some work
Console.WriteLine("Main thread is working...");

// Keep the application running
Console.ReadLine();