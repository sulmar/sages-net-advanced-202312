using ThreadExample;

Console.WriteLine("Hello, Thread!");




// Uruchomienie procesu
// Process.Start("notepad.exe");

MailingService mailingService = new MailingService();

for (int i = 0; i < 10; i++)
{
    // mailingService.Send();

    // Utworzenie wątku z metodą bezparametryczną
    // Thread sendThread = new Thread(mailingService.Send);

    // Utworzenie wątku z metodą z parametrem
    // Thread sendThread = new Thread(new ParameterizedThreadStart(mailingService.SendToObject));
    // sendThread.Start($"john{i}@domain.com");

    Thread sendThread = new Thread(() => mailingService.SendTo($"john{i}@domain.com"));

    sendThread.Start();

    Thread.Sleep(500);

}


Console.WriteLine("Done.");

DownloaderTest();

Console.WriteLine("Press any key to exit.");
Console.ReadLine();


static void DownloaderTest()
{
    string[] urls =
    [
        "https://www.google.com",
        "https://www.microsoft.com",
        "https://www.apple.com"
    ];

    Downloader downloader = new Downloader();

    ICollection<Thread> threads = new List<Thread>();

    foreach (string url in urls)
    {
        Thread t = new Thread(() => downloader.Download(url));
        threads.Add(t);
    }

    foreach (Thread t in threads)
    {
        t.Start();
    }
}