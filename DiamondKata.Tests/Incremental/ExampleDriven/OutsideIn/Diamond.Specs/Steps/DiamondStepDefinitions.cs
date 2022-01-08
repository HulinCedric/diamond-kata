using TechTalk.SpecFlow;
using Xunit;

namespace DiamondKata.Tests.Incremental.ExampleDriven.OutsideIn.Diamond.Specs.Steps;

/// <summary>
///     <para>These test cases can be used to test-drive a solution to the diamond kata, in an incremental manner.</para>
///     <para>This is the acceptance test.</para>
///     <para>This file execute the example described in Diamond.feature file. It must not be  changed.</para>
///     <para>
///         In outside-in TDD, this represents the outer loop. It is possible to create new unit test files for the inner
///         loop, so to test classes behaviors that emerge during the implementation and refactoring of the outer loop.
///     </para>
///     <para>Instructions:</para>
///     <list type="number">
///         <item>Make the first acceptance test pass (by returning the hardcoded result).</item>
///         <item>Proceed by small steps of refactoring, and let, as always as possible, the acceptance test pass.</item>
///         <item>If extracted class behavior need to be unit tested, use <see cref="DiamondInnerLoop" /> file.</item>
///         <item>When the refactoring is ended, uncomment another example in feature file.</item>
///     </list>
///     <para>When all the example test cases in this file are passing, you should have a full working solution.</para>
/// </summary>
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