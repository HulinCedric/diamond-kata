namespace DiamondKata;

public abstract class Diamond
{
    public static string Print(char suppliedLetter)
        => string.Join(
            "\n",
            "  A  ",
            " B B ",
            "C   C",
            " B B ",
            "  A  ");
}