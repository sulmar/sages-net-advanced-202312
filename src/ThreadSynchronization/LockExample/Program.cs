

using LockExample;


LoadBalanceRequestTest(15);

static void LoadBalanceRequestTest(int numberOfRequests)
{
    LoadBalancer loadBalancer = new LoadBalancer();

    for (int i = 0; i < numberOfRequests; i++)
    {
        Server server = loadBalancer.NextServer;
        Console.WriteLine($"Send request to: {server.Name} {server.IP}");
    }
}


Console.ReadKey();
