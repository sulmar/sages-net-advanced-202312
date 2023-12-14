using BlockingCollectionExample;
using System.Collections.Concurrent;

Console.WriteLine("Hello, BlockingCollection!");

// Producer - Consument

var imageQueue = new BlockingCollection<string>();

ImageProducer imageProducer = new(imageQueue);
ImageConsumer imageConsumer = new(imageQueue);
DbImageConsumer dbImageConsumer = new(imageQueue, new DbImageRepository());


// Uruchamiamy konsumenta w trybie "słuchacza"
Task.Run(() => imageConsumer.StartProcessing());
Task.Run(() => dbImageConsumer.StartProcessing());

// Uruchamy producenta
await imageProducer.StartProducingAsync();

Console.WriteLine("Press any key to exit.");
Console.ReadLine();

