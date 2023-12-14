using System.Collections.Concurrent;

namespace BlockingCollectionExample;

internal class ImageConsumer
{
    private readonly BlockingCollection<string> imageQueue;

    public ImageConsumer(BlockingCollection<string> imageQueue)
    {
        this.imageQueue = imageQueue;
    }

    public void StartProcessing()
    {
        Console.WriteLine("Waiting for images...");

        foreach (var image in imageQueue.GetConsumingEnumerable())
        {
            Console.WriteLine($"Processing OCR for {image}...");

            Thread.Sleep(1000);

            Console.WriteLine("Done.");
        }
    }
}
