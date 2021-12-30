using FsCheck;

namespace DiamondKata.Tests.Incremental.PropertyDriven;

public static class SupplyLetterGenerator
{
    public static Arbitrary<char> Generate()
        => Arb.Default.Char().Filter(c => c is >= 'A' and <= 'Z');
}