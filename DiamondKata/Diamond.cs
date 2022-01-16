namespace DiamondKata;

public abstract class Diamond
{
    public static string Print(char suppliedLetter)
    {
        var upperLeftCorner = new List<string>
        {
            "  A",
            " B ",
            GenerateLeftCorner("C  ")
        };
        return string.Join(
            "\n",
            Mirror(upperLeftCorner)
                .Select(MirrorLine));
    }

    private static string GenerateLeftCorner(string character)
        => "C  ";

    private static string MirrorLine(string line)
    {
        var characters = line.ToCharArray().Select(c => c.ToString()).ToList();

        var mirrorCharacters = Mirror(characters);

        var mirrorLine = string.Join("", mirrorCharacters);

        return mirrorLine;
    }

    private static List<string> Mirror(List<string> lines)
    {
        var firstLines = lines;
        var newLines = new List<string>(firstLines);

        var reversedFirstLinesWithoutLastEntry = WithoutLastEntry(firstLines).ToList();

        reversedFirstLinesWithoutLastEntry.Reverse();

        newLines.AddRange(reversedFirstLinesWithoutLastEntry);
        return newLines.ToList();
    }

    private static IEnumerable<string> WithoutLastEntry(IEnumerable<string> firstLines)
        => firstLines.SkipLast(1).ToList();
}