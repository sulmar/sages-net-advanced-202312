using SemaphoreExample;

Console.WriteLine("Hello, Semaphore!");

RequestLimiter requestLimiter = new RequestLimiter(3); // TODO: Limit to 3 concurrent requests

for (int i = 1; i <= 20; i++)
{
    int requestId = i;
    Thread thread = new Thread(() => requestLimiter.ProcessRequest(requestId));
    thread.Start();
}

Console.ReadLine();