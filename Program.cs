// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public interface IMoon
{
    MoonType Type { get; }
    bool IsStolen { get; }

    /// <summary>
    /// Returns whether the moon could be reasonably interpreted as being made from cheese
    /// by the average Brit and his hyper-intelligent dog.
    /// </summary>
    bool IsCheese { get; }
}

public enum MoonType { None, Moon, NotAMoonButASpaceStation }