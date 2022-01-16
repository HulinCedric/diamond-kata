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
        var firstLines = lines;
        var newLines = new List<string>(firstLines);

        var reversedFirstLines = new List<string>
        {
            "  A  ",
            " B B "
        };

        reversedFirstLines.Reverse();

        newLines.AddRange(reversedFirstLines);
        return newLines.ToArray();
    }
}