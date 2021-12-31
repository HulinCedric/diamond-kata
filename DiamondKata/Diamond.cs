using System.Text;

namespace DiamondKata;

public abstract class Diamond
{
    private const char LineSeparator = '\n';
    private const char StartLetter = 'A';
    private const char InterSpaceCharacter = ' ';
    private const char IndentationCharacter = ' ';

    public static string Print(char suppliedLetter)
        => string.Join(LineSeparator, PrintLines(suppliedLetter));

    private static string[] PrintLines(char suppliedLetter)
    {
        var diamondLines = new List<string>();

        var topHalfDiamondLines = GiveHalfDiamondLines(suppliedLetter).ToList();

        diamondLines.AddRange(topHalfDiamondLines.Select(l => l.ToString()));

        topHalfDiamondLines.Reverse();

        diamondLines.AddRange(topHalfDiamondLines.Skip(1).Select(l => l.ToString()));

        return diamondLines.ToArray();
    }

    private static IEnumerable<StringBuilder> GiveHalfDiamondLines(char suppliedLetter)
    {
        for (var nextLetter = StartLetter;
             nextLetter <= suppliedLetter;
             nextLetter = GetNextLetter(nextLetter))
            yield return BuildLine(suppliedLetter, nextLetter);
    }

    private static StringBuilder BuildLine(char suppliedLetter, char currentLetter)
    {
        var lineResult = new StringBuilder();

        var indentation = GetIndentation(suppliedLetter, currentLetter);
        lineResult.Append(indentation);

        lineResult.Append(currentLetter);

        var interSpace = GetInterSpace(currentLetter);
        lineResult.Append(interSpace);

        if (currentLetter != StartLetter)
            lineResult.Append(currentLetter);

        lineResult.Append(indentation);

        return lineResult;
    }

    private static string GetInterSpace(char currentLetter)
    {
        var interSpaceCount = (currentLetter - StartLetter) * 2 - 1;

        return RepeatCharacter(InterSpaceCharacter, interSpaceCount);
    }

    private static string GetIndentation(char suppliedLetter, char currentLetter)
    {
        var indentationCount = suppliedLetter - currentLetter;

        return RepeatCharacter(IndentationCharacter, indentationCount);
    }

    private static char GetNextLetter(char letter)
        => (char)(letter + 1);

    private static string RepeatCharacter(char character, int count)
    {
        if (count <= 0)
            return string.Empty;

        return string.Join(string.Empty, Enumerable.Repeat(character, count));
    }
}