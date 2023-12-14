using System.Collections.Concurrent;

namespace BlockingCollectionExample;

internal class DbImageConsumer
{
    private readonly BlockingCollection<string> imageQueue;
    private readonly IImageRepository imageRepository;

    public DbImageConsumer(BlockingCollection<string> imageQueue, IImageRepository imageRepository)
    {
        this.imageQueue = imageQueue;
        this.imageRepository = imageRepository;
    }

    public void StartProcessing()
    {
        Console.WriteLine("Waiting for images...");

        foreach (var image in imageQueue.GetConsumingEnumerable())
        {
            imageRepository.Add(image);
        }
    }

}
