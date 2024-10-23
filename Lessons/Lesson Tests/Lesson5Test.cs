using Lesson_5.models;

namespace Lesson_Tests;

public class Lesson5Test
{
    #region Propreties

    private Student student;
    #endregion
    
    #region Setup
    [SetUp]
    public void Setup()
    {
        student = new Student();
    }
    #endregion

    #region Tests
    // Test method with multiple test cases
    [TestCase(2020, 01, 01, 4)]
    [TestCase(2020, 12, 31, 3)]
    public void Age(int year, int month, int day, int expected)
    {
        // Arrange (args var values)
        DateOnly input = new DateOnly(year, month, day);
        
        // Act
        int result = student.CalculateAge(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    #endregion
}