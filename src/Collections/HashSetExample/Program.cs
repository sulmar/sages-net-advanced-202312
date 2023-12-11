// See https://aka.ms/new-console-template for more information
using HashSetExample;
using Collections.Core;

Console.WriteLine("Hello, HashSet!");

TrackingServiceTest();

static void TrackingServiceTest()
{
    TrackingService trackingService = new TrackingService();

    string[] ipAddresses =
    {
        "192.168.0.1",
        "10.0.0.1",
        "192.168.0.1",
        "192.168.0.2",
        "10.0.0.1",
        "192.168.0.3"
    };    
    
    foreach (string ipAddress in ipAddresses)
    {
        trackingService.TrackIP(ipAddress);
    }

    var uniqueIPs = trackingService.GetUniqueIPs();

    uniqueIPs.Dump("List of Unique IP Addresses:");    
}

