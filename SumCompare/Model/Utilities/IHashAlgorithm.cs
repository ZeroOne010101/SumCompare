namespace SumCompare.Utilities;

public interface IHashAlgorithm
{
    public string AlgorithmName { get; }
    public string FileHash(string path);
    public string TextHash(string text);
}