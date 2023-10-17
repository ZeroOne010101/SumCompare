using SumCompare.Utilities;
using System.IO;
using System.Text;

namespace SumCompare.HashAlgorithms;

public class SHA1 : IHashAlgorithm
{
    public string AlgorithmName { get; set; } = "SHA1";

    public string FileHash(string path)
    {
        using Stream stream = File.OpenRead(path);
        byte[] hash = System.Security.Cryptography.SHA1.HashData(stream);
        return System.BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
    }

    public string TextHash(string text)
    {
        byte[] textBytes = Encoding.UTF8.GetBytes(text);
        byte[] hash = System.Security.Cryptography.SHA1.HashData(textBytes);
        return System.BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
    }
}