using SemaphoreExample;

Console.WriteLine("Hello, Semaphore!");

RequestLimiter requestLimiter = new RequestLimiter(2); // TODO: Limit to 2 concurrent requests

for (int i = 1; i <= 10; i++)
{
    int requestId = i;
    Thread thread = new Thread(() => requestLimiter.ProcessRequest(requestId));
    thread.Start();
}

Console.ReadLine();