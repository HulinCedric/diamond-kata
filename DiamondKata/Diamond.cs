using System.Text;

namespace DiamondKata;

public abstract class Diamond
{
    private const char StartingLetter = 'A';

    public static string Print(char suppliedLetter)
    {
        if (suppliedLetter == StartingLetter)
            return $"{StartingLetter}";

        var printResult = new StringBuilder($"{StartingLetter}");
        printResult.Append('\n');

        for (var nextLetter = GetNextLetter(StartingLetter);
             nextLetter <= suppliedLetter;
             nextLetter = GetNextLetter(nextLetter))
        {
            printResult.Append(string.Join(string.Empty, Enumerable.Repeat(nextLetter, 2)));
            printResult.Append('\n');
        }

        return printResult.ToString();
    }

    private static char GetNextLetter(char letter)
        => (char)(letter + 1);
}