using Lesson_2.Examples;

namespace Lesson_Tests;

[TestFixture]
public class Lesson2Test
{
    [SetUp]
    public void Setup()
    {
        // if we need to initialize objects,
        // set up test data, or perform any
        // necessary configuration that the
        // test methods depend on.
    }

    // Test method with multiple test cases
    [TestCase("hello", "olleh")]
    [TestCase("world", "dlrow")]
    [TestCase("C#", "#C")]
    [TestCase("NUnit", "tinUN")]
    [TestCase("", "")]          // Edge case: empty string
    [TestCase("a", "a")]        // Edge case: single character
    public void TestFizzBuzz(string input, string expected)
    {
        // Arrange (args var values)

        // Act
        string result = Exercises.ReverseString(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}