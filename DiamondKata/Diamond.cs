namespace DiamondKata;

public abstract class Diamond
{
    private const char StartingLetter = 'A';

    public static string Print(char suppliedLetter)
    {
        var result = string.Empty;

        for (var letter = StartingLetter; letter <= suppliedLetter; letter++)
            result += letter;

        return result;
    }
}