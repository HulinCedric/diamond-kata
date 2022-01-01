using TechTalk.SpecFlow;
using Xunit;

namespace DiamondKata.Tests.Incremental.ExampleDriven.OutsideIn.Diamond.Specs.Steps;

[Binding]
public sealed class DiamondStepDefinitions
{
    private string actualPrintResult = null!;

    private char suppliedLetter;

    [Given(@"the letter '(.*)'")]
    public void GivenTheLetter(char letter)
        => suppliedLetter = letter;

    [When(@"print a diamond")]
    public void WhenPrintADiamond()
        => actualPrintResult = DiamondKata.Diamond.Print(suppliedLetter);

    [Then(@"diamond prints")]
    public void ThenDiamondPrints(string expectedPrintResult)
    {
        expectedPrintResult = expectedPrintResult.Replace("\r", "");
        Assert.Equal(expectedPrintResult, actualPrintResult);
    }
}