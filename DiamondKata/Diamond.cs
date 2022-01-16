namespace DiamondKata;

public abstract class Diamond
{
    public static string Print(char suppliedLetter)
    {
        var reversedAlphabetLetters = GetReversedAlphabetFrom(suppliedLetter);

        var upperLeftCorner = reversedAlphabetLetters
            .Reverse()
            .Select(c => GenerateLeftCorner(reversedAlphabetLetters, c))
            .ToList();
        return string.Join(
            "\n",
            Mirror(upperLeftCorner)
                .Select(MirrorLine));
    }

    private static string GetReversedAlphabetFrom(char letter)
    {
        var endLetter = letter;

        var reversedAlphabet = GetReversedAlphabetCharactersFrom(endLetter);

        return string.Join("", reversedAlphabet);
    }

    private static IEnumerable<char> GetReversedAlphabetCharactersFrom(char endLetter)
    {
        for (var current = endLetter; current >= 'A'; current--)
            yield return current;
    }

    private static string GenerateLeftCorner(string letters, char character)
    {
        var orderedCharacters = letters.ToCharArray();

        var replacedWithSeparatorExceptCharacter = orderedCharacters.Select(
            c => c == character ?
                     character : ' ');

        return string.Join("", replacedWithSeparatorExceptCharacter);
    }

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