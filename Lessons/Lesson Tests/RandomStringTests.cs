namespace Lesson_Tests;

[TestFixture]
public class RandomStringTests
{
    #region Properties

    private Utils.String _instance;
    #endregion
    
    #region Setup
    [SetUp]
    public void Setup()
    {
        _instance = new Utils.String();
    }
    #endregion

    #region Tests
    [TestCase(5, 10)]
    [TestCase(10, 20)]
    [TestCase(0, 10)]
    [TestCase(5, 0)]
    public void RandomStrings_ReturnsCorrectCountAndLength(int count, int length)
    {
        // Act
        string[] result = _instance.RandomStrings(count, length);

        // Assert
        Assert.AreEqual(count, result.Length, "The number of generated strings does not match the count.");

        foreach (var str in result)
        {
            Assert.AreEqual(length, str.Length, "One of the generated strings does not match the expected length.");
        }
    }

    [TestCase(1000, 5)] // Test with a high count to check uniqueness
    public void RandomStrings_ReturnsUniqueStrings(int count, int length)
    {
        // Act
        string[] result = _instance.RandomStrings(count, length);

        // Assert
        var uniqueStrings = new HashSet<string>(result);
        Assert.AreEqual(count, uniqueStrings.Count, "Generated strings are not unique.");
    }

    [TestCase(-1, 10)]
    [TestCase(5, -1)]
    public void RandomStrings_ThrowsArgumentExceptionForInvalidInput(int count, int length)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _instance.RandomStrings(count, length));
    }
    #endregion
}