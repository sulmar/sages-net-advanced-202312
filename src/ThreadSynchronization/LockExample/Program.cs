

using LockExample;

//var loadBalancer1 = LoadBalancer.Instance;
//var loadBalancer2 = LoadBalancer.Instance;

//if (ReferenceEquals(loadBalancer1, loadBalancer2))
//{
//    Console.WriteLine("The same");
//}
//else
//{
//    Console.WriteLine("Not the same");
//}

//return;

//LoadBalanceRequestTest(15);
//LoadBalanceRequestTest(15);

Thread t1 = new Thread(() => LoadBalanceRequestTest(15));

Thread t2 = new Thread(() => LoadBalanceRequestTest(15));

t1.Start();

Thread.Sleep(1000);

t2.Start();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

static void LoadBalanceRequestTest(int numberOfRequests)
{
    LoadBalancer loadBalancer = LoadBalancer.Instance;

    for (int i = 0; i < numberOfRequests; i++)
    {
        Server server = loadBalancer.NextServer;
    }
}


Console.ReadKey();
