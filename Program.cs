// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public interface IMoon
{
    MoonType Type { get; }
    bool IsStolen { get; }
}

public enum MoonType { None, Moon, NotAMoonButASpaceStation }