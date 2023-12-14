namespace LockExample;

internal class LoadBalancer
{
    private readonly List<Server> servers;

    private readonly Random random = new Random();

    private static LoadBalancer _instance;
    public static LoadBalancer Instance
    {
        get
        {
            if (_instance == null) // <-- 
            {
                _instance = new LoadBalancer();
            }

            return _instance;
        }
    }

    protected LoadBalancer()
    {
        Dump("Initialize");

        servers =
        [
            new Server { Name = "ServerA", IP = "192.168.0.18" },
            new Server { Name = "ServerB", IP = "192.168.0.19" },
            new Server { Name = "ServerC", IP = "192.168.0.20" },
            new Server { Name = "ServerD", IP = "192.168.0.21" },
            new Server { Name = "ServerE", IP = "192.168.0.22" },
        ];

        Thread.Sleep(1000);
    }

    // Simple Load Balancer
    public Server NextServer
    {
        get
        {
            var server = servers[random.Next(servers.Count)];

            Dump($"Send request to: {server.Name} {server.IP}");

            return server;
        }
    }

    private static void Dump(string message) => Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} {message}");

}



public class Server
{
    public string Name { get; set; }
    public string IP { get; set; }
}
