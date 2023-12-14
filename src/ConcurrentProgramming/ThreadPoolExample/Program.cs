using ThreadPoolExample;

Console.WriteLine("Hello, Thread Pool!");

MailingService mailingService = new MailingService();

ThreadPool.GetAvailableThreads(out int workerThreads, out int workerCount);

Console.WriteLine($"{workerThreads} {workerCount}");

// bool s = ThreadPool.SetMaxThreads(1, 1);

for (int i = 0; i < 100; i++)
{
    ThreadPool.QueueUserWorkItem(mailingService.SendToObject, $"john{i}@domain.com");

    Thread.Sleep(500);

}

Console.WriteLine("Done.");


Console.WriteLine("Press any key to exit.");
Console.ReadLine();