namespace SumCompare.Utilities;

public interface IHashAlgorithm
{
    public string Name { get; }
    public string FileHash(string path);
    public string TextHash(string text);
}