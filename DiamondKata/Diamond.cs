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
            " B B ",
            "  A  "
        };


        newLines.AddRange(reversedFirstLines);
        return newLines.ToArray();
    }
}