using System.Collections;

namespace HashSetExample;

class Image
{
    public byte[] Content { get; set; }

    public override int GetHashCode()
    {
        return BitConverter.ToInt32(Content);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Image otherImage = (Image)obj;

        return StructuralComparisons.StructuralEqualityComparer.Equals(Content, otherImage.Content);
    }

    public Image(byte[] content)
    {
        Content = content;
    }

    public override string ToString()
    {
        return $"{this.GetHashCode()}";
    }
}

internal class ImageService
{
    private readonly HashSet<Image> _images = new HashSet<Image>();

    public void TakeImage(Image image)
    {
        _images.Add(image);
    }
}

internal class TrackingService
{
    // Złożoność obliczeniowa O(1)
    private readonly HashSet<string> _uniqueIPs = new HashSet<string>();

    public void TrackIP(string ipAddress)
    {
        if (_uniqueIPs.Add(ipAddress))
        {
            Console.WriteLine($"New IP Address {ipAddress}");
        }
        else
        {
            Console.WriteLine($"Duplicate IP Address {ipAddress}");
        }
    }

    public IEnumerable<string> GetUniqueIPs()
    {
        return _uniqueIPs;
    }


}
