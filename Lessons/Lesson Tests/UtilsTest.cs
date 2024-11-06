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
    public void TestAgeWithDateOnly(int year, int month, int day, int expected)
    {
        // arrange
        DateOnly input = new DateOnly(year, month, day);
        
        // act
        int result = date.Age(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [TestCase(2020, 01, 01, 4)]
    [TestCase(2020, 12, 31, 3)]
    public void TestAgeWithPrimitives(int year, int month, int day, int expected)
    {
        // act
        int result = date.Age(year, month, day);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    #endregion
}