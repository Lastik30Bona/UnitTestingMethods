using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "S";
        string expected = "S";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "abc";
        string expected = "cba";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(result, expected);
    }
}
