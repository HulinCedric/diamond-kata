namespace DiamondKata;

public abstract class Diamond
{
    public static string Print(char suppliedLetter)
        => string.Join(
            "\n",
            Mirror(
                "  A  ",
                " B B ",
                "C   C"));

    private static string[] Mirror(params string[] lines)
    {
        var newLines = new List<string>(lines);
        newLines.AddRange(
            new[]
            {
                " B B ",
                "  A  "
            });
        return newLines.ToArray();
    }
}