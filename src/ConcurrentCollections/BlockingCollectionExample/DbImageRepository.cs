namespace BlockingCollectionExample;

internal class DbImageRepository : IImageRepository
{
    private readonly List<string> images = new List<string>();

    public void Add(string image)
    {
        Console.WriteLine($"Add {image} to database...");

        images.Add(image);

        Thread.Sleep(100);

        Console.WriteLine("Added.");        
    }
}
