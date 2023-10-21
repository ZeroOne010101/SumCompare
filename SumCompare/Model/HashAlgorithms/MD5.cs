using SumCompare.Utilities;
using System.IO;
using System.Text;

namespace SumCompare.HashAlgorithms;

public class MD5 : IHashAlgorithm
{
    public string Name { get; } = "MD5";

    public string FileHash(string path)
    {
        using Stream stream = File.OpenRead(path);
        byte[] hash = System.Security.Cryptography.MD5.HashData(stream);
        return System.BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
    }

    public string TextHash(string text)
    {
        byte[] textBytes = Encoding.UTF8.GetBytes(text);
        byte[] hash = System.Security.Cryptography.MD5.HashData(textBytes);
        return System.BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
    }
}