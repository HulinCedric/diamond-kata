using DiamondKata.Tests.Incremental.ExampleDriven.OutsideIn.Diamond.Specs.Steps;
using Xunit;

namespace DiamondKata.Tests.Incremental.ExampleDriven.OutsideIn;

/// <summary>
///     <para>Do not start here first, please check the acceptance test before <see cref="DiamondStepDefinitions" />.</para>
///     <para>These file can be used to test-drive collaborators (if there are) of diamond kata solution.</para>
///     <para>In Outside-in TDD, these represent the inner loop.</para>
/// </summary>
public class DiamondInnerLoop
{
    [Fact(Skip = "Remove the Skip property when needed")]
    public void Use_me_when_needed()
        => Assert.True(false);
}