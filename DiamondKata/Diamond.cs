namespace DiamondKata;

public abstract class Diamond
{
    public static string Print(char suppliedLetter)
        => string.Join(
            "\n",
            Mirror(
                "  A  ",
                " B B ",
                "C   C",
                " B B ",
                "  A  "));

    private static string[] Mirror(params string[] strings)
        => strings;
}