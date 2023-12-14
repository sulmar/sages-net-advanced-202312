using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExample;

internal class Downloader
{
    public void Download(string url)
    {
        var client = new WebClient();

        Dump($"Downloading {url}...");

        string content = client.DownloadString(url);

        Dump($"Downloaded {url}. Transferred: {content.Length}");
    }

    private static void Dump(string message) => Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} {message}");
}
