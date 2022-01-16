namespace DiamondKata;

public abstract class Diamond
{
    public static string Print(char suppliedLetter)
        => string.Join(
            "\n",
            Mirror(
                MirrorLine("  A"),
                " B B ",
                "C   C"));

    private static string MirrorLine(string line)
    {
        var characters = line.ToCharArray().Select(c => c.ToString());

        var mirrorCharacters = characters;

        var mirrorLine = string.Join("", mirrorCharacters) + "  ";

        return mirrorLine;
    }

    private static string[] Mirror(params string[] lines)
    {
        var firstLines = lines;
        var newLines = new List<string>(firstLines);

        var reversedFirstLinesWithoutLastEntry = WithoutLastEntry(firstLines).ToList();

        reversedFirstLinesWithoutLastEntry.Reverse();

        newLines.AddRange(reversedFirstLinesWithoutLastEntry);
        return newLines.ToArray();
    }

    private static IEnumerable<string> WithoutLastEntry(IEnumerable<string> firstLines)
        => firstLines.SkipLast(1).ToList();
}