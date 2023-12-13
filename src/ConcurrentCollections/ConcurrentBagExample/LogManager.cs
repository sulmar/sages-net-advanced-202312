using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentBagExample;

internal class LogManager
{
    private List<string> logEntries = new List<string>();

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Thread {Thread.CurrentThread.ManagedThreadId}: {message}";

        logEntries.Add(logEntry);

    }

    public void ProcessLogs()
    {
        // Use a separate thread to periodically process logs
        Task.Run(() =>
        {
            while (true)
            {
                // Simulate processing logs every 5 seconds
                Thread.Sleep(TimeSpan.FromSeconds(5));

                Console.WriteLine("===== Log Entries =====");
                foreach (var logEntry in logEntries)
                {
                    Console.WriteLine(logEntry);
                }
                Console.WriteLine("=======================");

            }
        });
    }

}
