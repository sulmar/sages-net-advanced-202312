// See https://aka.ms/new-console-template for more information
using HashSetExample;
using Collections.Core;

Console.WriteLine("Hello, HashSet!");

HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };

// Suma zbiorów
HashSet<int> unionSet = new HashSet<int>(set1); // tworzona jest kopia z oryginalnego zbioru
unionSet.UnionWith(set2);

unionSet.Dump("Union of set1 and set2");


// Różnica zbiorów
HashSet<int> diffSet = new HashSet<int>(set1);
diffSet.ExceptWith(set2);

diffSet.Dump("Difference of set1 and set2");

// Iloczyn zbiorów (część wspólna zbiorów)
HashSet<int> interSet = new HashSet<int>(set1);
interSet.IntersectWith(set2);
interSet.Dump("Intersection of set1 and set2");


// TrackingServiceTest();

// ImageServiceTest();

Console.WriteLine();


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

static void ImageServiceTest()
{
    ImageService imageService = new ImageService();
    var image1 = new Image([1, 2, 3, 4]);
    var image2 = new Image([1, 2, 3, 4, 5]);
    var image3 = new Image([1, 2, 3, 4]);

    imageService.TakeImage(image1);
    imageService.TakeImage(image2);
    imageService.TakeImage(image3);
}