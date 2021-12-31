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

    private static StringBuilder PrepareLine(char suppliedLetter, char currentLetter)
    {
        var lineResult = new StringBuilder();

        var indentation = GetIndentation(suppliedLetter, currentLetter);

        lineResult.Append(indentation);

        lineResult.Append(currentLetter);

        var interSpace = GetInterSpace(currentLetter);
        lineResult.Append(interSpace);

        if (currentLetter != StartingLetter)
            lineResult.Append(currentLetter);

        lineResult.Append(indentation);

        return lineResult;
    }

    private static string GetInterSpace(char currentLetter)
    {
        const char interSpaceCharacter = ' ';

        var interSpaceCharacterCount = (currentLetter - StartingLetter) * 2 - 1;

        return RepeatCharacter(interSpaceCharacter, interSpaceCharacterCount);
    }

    private static string GetIndentation(char suppliedLetter, char currentLetter)
    {
        const char indentationCharacter = ' ';

        var indentationCount = suppliedLetter - currentLetter;

        return RepeatCharacter(indentationCharacter, indentationCount);
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