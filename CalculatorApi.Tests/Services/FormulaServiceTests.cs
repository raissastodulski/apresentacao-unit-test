using Xunit;
using CalculatorApi.Services;
using Moq;

namespace CalculatorApi.Tests.Services;

public class FormulaServiceTests
{
    private FormulaService service;
    private Mock<IBasicOperationService> mockBasicOperationService;
    private const double a = 6;
    private const double b = 3;
    private const double c = 7;

    public FormulaServiceTests()
    {
        mockBasicOperationService = new Mock<IBasicOperationService>();
        mockBasicOperationService.Setup(x => x.Multiply(b, b)).Returns(b * b);
        // mockBasicOperationService.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns(9);
        service = new FormulaService(mockBasicOperationService.Object);
        
    }

    [Fact]
    public void CalculateDelteMustReturnCorrectResult()
    {
        // Arrange
        var expected = -159;

        // Act
        var result = service.Delta(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }
}
