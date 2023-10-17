using Avalonia.Controls;
using System.Collections.Generic;

namespace SumCompare;

public static class WindowManager
{
    static readonly Dictionary<string, Window> windowDict = new();

    public static void Add(string name, Window window)
    {
        windowDict.Add(name, window);
    }

    public static Window Get(string name)
    {
        return windowDict[name];
    }

    public static void Remove(string name)
    {
        windowDict.Remove(name);
    }
}
