using SumCompare.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;

namespace SumCompare;

public abstract class HashGenerator
{
    public static Dictionary<string, IHashAlgorithm> Algorithms { get; set; } = new();
    public static void Initialize()
    {
        // Use Reflection to get all classes in SumCompare.HashAlgorithms
        List<Type> algorithmTypes = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => t.IsClass && t.Namespace == "SumCompare.HashAlgorithms")
                            .ToList();

        // Instantiate resulting Types and cast to Interface
        foreach (Type algorithmType in algorithmTypes)
        {
            IHashAlgorithm? hashAlgorithm = (IHashAlgorithm?)Activator.CreateInstance(algorithmType);
            if (hashAlgorithm is not null and IHashAlgorithm)
            {
                HashGenerator.Algorithms.Add(hashAlgorithm.AlgorithmName, hashAlgorithm);
            }
            else
            {
                throw new SumCompareException("Reflected object null or not child of IHashAlgorithm. This should never happen.");
            }
        }
    }
    public static string GetFilePath(string path)
    {
        string filePath = "";

        // Get the full path
        try
        {
            filePath = Path.GetFullPath(path);
        }
        catch (Exception e) when (e is SecurityException || e is PathTooLongException)
        {
            throw new InvalidFilePath($"Path {filePath} is invalid.");
        }

        // Check if the path actually exists
        if (Path.Exists(filePath))
        {
            return filePath;
        }
        else
        {
            throw new InvalidFilePath($"Path {filePath} is invalid.");
        }
    }
    public static string GetFileHash(string path, IHashAlgorithm algorithm)
    {
        return algorithm.FileHash(GetFilePath(path));
    }
    public static string GetTextHash(string text, IHashAlgorithm algorithm)
    {
        return algorithm.TextHash(text);
    }
}
