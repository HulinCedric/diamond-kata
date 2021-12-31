using System.Collections.Generic;
using System.Linq;
using FsCheck;
using FsCheck.Xunit;

namespace DiamondKata.Tests.Incremental.PropertyDriven;

/// <summary>
///     <para>These test cases can be used to test-drive a solution to the diamond kata, in an incremental manner.</para>
///     <para>Instructions:</para>
///     <list type="number">
///         <item>Make the first test case pass.</item>
///         <item>Remove the 'Skip' property and enable the next test case.</item>
///         <item>Make it pass.</item>
///         <item>When all the lines of code in the test case are passing, enable the next test case.</item>
///     </list>
///     <para>When all the test cases in this file are passing, you should have a full working solution.</para>
/// </summary>
[Properties(Arbitrary = new[] { typeof(SupplyLetterGenerator) })]
public class DiamondShould
{
    /// Devil's Advocate example:
    /// <example>"Devil's advocate."</example>
    [Property]
    public Property Not_be_empty(char suppliedLetter)
    {
        var diamond = Diamond.Print(suppliedLetter);

        return (!string.IsNullOrWhiteSpace(diamond)).Label("Diamond is not null, empty or whitespace");
    }

    /// Devil's Advocate example:
    /// <example>"    A "</example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Contains_A_in_first_line(char suppliedLetter)
    {
        var diamond = Diamond.Print(suppliedLetter);

        var diamondTrimmedLines = diamond.GetLines().Select(line => line.Trim());

        return (diamondTrimmedLines.First() == "A").Label("First line contains A");
    }

    /// Devil's Advocate example:
    /// <example>"    A "</example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Contains_A_in_last_line(char suppliedLetter)
    {
        var diamond = Diamond.Print(suppliedLetter);

        var diamondTrimmedLines = diamond.GetLines().Select(line => line.Trim());

        return (diamondTrimmedLines.Last() == "A").Label("Last line contains A");
    }

    /// Devil's Advocate example:
    /// <example>"    A    "</example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Have_a_vertically_symmetric_contour(char suppliedLetter)
    {
        var diamond = Diamond.Print(suppliedLetter);

        var diamondLines = diamond.GetLines();

        return diamondLines.All(
                line =>
                    LeadingSpaces(line) == TrailingSpaces(line))
            .Label("All lines must have a symmetric contour");
    }

    /// Devil's Advocate example:
    /// <example>
    ///     " A "
    ///     " B "
    ///     " C "
    ///     " D "
    ///     " C "
    ///     " B "
    ///     " A "
    /// </example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Contain_lines_with_correct_letter_in_correct_order(char suppliedLetter)
    {
        // Given
        var expectedLetters = new List<char>();

        // With alphabetical order letters
        for (var letter = 'A'; letter < suppliedLetter; letter++)
            expectedLetters.Add(letter);

        // And with reverse alphabetical order letters
        for (var letter = suppliedLetter; letter >= 'A'; letter--)
            expectedLetters.Add(letter);

        // When
        var diamond = Diamond.Print(suppliedLetter);

        // Then
        var diamondLines = diamond.GetLines();

        var diamondLineLetters = diamondLines.Select(ExtractLetter);

        return diamondLineLetters
            .SequenceEqual(expectedLetters)
            .Label("Lines must contain the correct letters, in the correct order");
    }

    /// Devil's Advocate example:
    /// <example>
    ///     "   A   "
    ///     "BBBBBBB"
    ///     "CCCCCCC"
    ///     "DDDDDDD"
    ///     "CCCCCCC"
    ///     "BBBBBBB"
    ///     "   A   "
    /// </example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Have_width_equals_to_the_height(char suppliedLetter)
    {
        // When
        var diamond = Diamond.Print(suppliedLetter);

        // Then
        var diamondLines = diamond.GetLines();

        return diamondLines
            .All(line => line.Length == diamondLines.Length)
            .Label("Diamond is as wide as it is high");
    }

    /// Devil's Advocate example:
    /// <example>
    ///     "   A   "
    ///     "B     B"
    ///     "C     C"
    ///     "D     D"
    ///     "C     C"
    ///     "B     B"
    ///     "   A   "
    /// </example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Contain_lines_with_two_identical_letters_except_for_the_top_and_the_bottom(char suppliedLetter)
    {
        // When
        var diamond = Diamond.Print(suppliedLetter);

        // Then
        var diamondLines = diamond.GetLines();

        return diamondLines
            .Where(line => !line.Contains('A'))
            .Select(line => line.Replace(" ", ""))
            .All(IsTwoIdenticalLetters)
            .Label("All lines except top and bottom have two identical letters");
    }

    /// Devil's Advocate example:
    /// <example>
    ///     "   A   "
    ///     "  B B  "
    ///     "  C C  "
    ///     "D     D"
    ///     " C   C "
    ///     "  B B  "
    ///     "   A   "
    /// </example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Have_lower_left_space_as_a_triangle(char suppliedLetter)
    {
        var diamond = Diamond.Print(suppliedLetter);

        var diamondLines = diamond.GetLines();

        var lowerLeftSpaces = diamondLines
            .SkipWhile(line => !line.Contains(suppliedLetter))
            .Select(LeadingSpaces);

        var lowerLeftSpaceCounts = lowerLeftSpaces.Select(space => space.Length);

        return Enumerable.Range(0, 25)
            .Zip(lowerLeftSpaceCounts)
            .All(
                zip =>
                {
                    var (lineNumber, lowerLeftSpaceCount) = zip;
                    return lineNumber == lowerLeftSpaceCount;
                })
            .Label("Lower left space is a triangle");
    }

    /// Devil's Advocate example:
    /// <example>
    ///     "   A   "
    ///     "  B B  "
    ///     " C   C "
    ///     "D     D"
    ///     " C   C "
    ///     "  B B  "
    ///     "   A   "
    /// </example>
    [Property(Skip = "1. Remove the 'Skip' property 2. Make it pass 3. Go to the next test")]
    public Property Be_symmetric_around_horizontal_axis(char suppliedLetter)
    {
        var diamond = Diamond.Print(suppliedLetter);

        var diamondLines = diamond.GetLines();

        var topLines = diamondLines
            .TakeWhile(line => !line.Contains(suppliedLetter))
            .ToList();

        var bottomLines = diamondLines
            .SkipWhile(line => !line.Contains(suppliedLetter))
            .Skip(1)
            .Reverse()
            .ToList();

        return topLines
            .SequenceEqual(bottomLines)
            .Label("Figure is symmetric around the horizontal axis");
    }

    private static string LeadingSpaces(string line)
    {
        var indexOfNonSpace = line.IndexOf(ExtractLetter(line));
        return line[..indexOfNonSpace];
    }

    private static string TrailingSpaces(string line)
    {
        var lastIndexOfNonSpace = line.LastIndexOf(ExtractLetter(line));
        return line[(lastIndexOfNonSpace + 1)..];
    }

    private static char ExtractLetter(string line)
        => line.First(c => c != ' ');

    private static bool IsTwoIdenticalLetters(string line)
    {
        var hasIdenticalLetters = line.Distinct().Count() == 1;
        var hasTwoLetters = line.Length == 2;
        return hasIdenticalLetters && hasTwoLetters;
    }
}