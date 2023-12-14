using System.Collections.Concurrent;

namespace BlockingCollectionExample;


internal class ImageProducer
{
    private readonly BlockingCollection<string> imageQueue;

    // https://learn.microsoft.com/pl-pl/dotnet/api/system.io.filesystemwatcher?view=net-8.0
    private FileSystemWatcher watcher;

    public ImageProducer(BlockingCollection<string> imageQueue)
    {
        this.imageQueue = imageQueue;

        watcher = new FileSystemWatcher(@"C:\temp\images");

        watcher.Created += Watcher_Created;

        watcher.Filter = "*.png";
        watcher.IncludeSubdirectories = true;
    }

    public async Task StartProducingAsync()
    {
        watcher.EnableRaisingEvents = true;
    }

    private void Watcher_Created(object sender, FileSystemEventArgs e)
    {
        string image = e.FullPath;

        imageQueue.Add(image);
    }
}
