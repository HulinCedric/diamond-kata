using System.Text;

namespace DiamondKata;

public abstract class Diamond
{
    private const char StartingLetter = 'A';

    public static string Print(char suppliedLetter)
    {
        if (suppliedLetter == StartingLetter)
            return $"{StartingLetter}";

        var printResult = new StringBuilder();

        for (var nextLetter = StartingLetter;
             nextLetter <= suppliedLetter;
             nextLetter = GetNextLetter(nextLetter))
        {
            printResult.Append(PrepareLine(suppliedLetter, nextLetter));
            printResult.Append('\n');
        }

        return printResult.ToString();
    }

    private static StringBuilder PrepareLine(char targetLetter, char currentLetter)
    {
        var lineResult = new StringBuilder();

        var indentationCount = targetLetter - currentLetter;
        var indentation = string.Join(string.Empty, Enumerable.Repeat(" ", indentationCount));

        lineResult.Append(indentation);

        var printLetter = $"{currentLetter}";
        lineResult.Append(printLetter);

        if (currentLetter != StartingLetter)
            lineResult.Append(printLetter);

        lineResult.Append(indentation);

        return lineResult;
    }

    private static char GetNextLetter(char letter)
        => (char)(letter + 1);
}