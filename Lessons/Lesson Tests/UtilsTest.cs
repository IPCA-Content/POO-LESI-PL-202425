using Utils;

namespace Lesson_Tests;

[TestFixture]
public class UtilsTest
{
    #region Properties

    private Date date;
    #endregion
    
    #region Setup
    [SetUp]
    public void Setup()
    {
        date = new Date();
    }
    #endregion

    #region Tests
    // Test method with multiple test cases
    [TestCase(2020, 01, 01, 4)]
    [TestCase(2020, 12, 31, 3)]
    public void Age(int year, int month, int day, int expected)
    {
        // arrange
        DateOnly input = new DateOnly(year, month, day);
        
        // act
        int result = date.Age(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    #endregion
}