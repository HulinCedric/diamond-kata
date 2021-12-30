namespace DiamondKata.Tests;

public static class DiamondTestExtensions
{
    public static string[] GetLines(this string diamond)
        => diamond.Split('\n');
}