using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPoolExample;

internal class MailingService
{
    Random _random = new Random();

    public void Send()
    {
        Dump($"Sending...");

        var duration = _random.Next(1000, 3000);

        Thread.Sleep(duration);

        Dump($"Sent. Elapsed time {duration}");
    }

    public void SendToObject(object email)
    {
        SendTo((string) email);
    }

    public void SendTo(string email)
    {
        Dump($"Sending to {email}...");

        var duration = _random.Next(1000, 3000);

        Thread.Sleep(duration);

        Dump($"Sent to {email}. Elapsed time {duration}");
    }

    private static void Dump(string message) => Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} {message}");
}
