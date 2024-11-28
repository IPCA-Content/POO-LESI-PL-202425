using Lesson10.Interfaces;
using Lesson10.Models;
using Moq;

namespace Lesson_Tests;

[TestFixture]
public class ReportGeneratorTests
{
    [Test]
    public void Generate_ShouldCallLoggerLogMethodOnce()
    {
        // Arrange
        Mock<ILogger> loggerMock = new Mock<ILogger>();
        ReportGenerator reportGenerator = new ReportGenerator(loggerMock.Object);

        // Act
        reportGenerator.GenerateReport();

        // Assert
        loggerMock.Verify(logger => logger.Log(It.Is<string>(s => s == "Report generated.")), Times.Once);
    }
}
