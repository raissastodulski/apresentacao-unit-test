using Xunit;
using CalculatorApi.Services;

namespace CalculatorApi.Tests.Services;

public class BasicOperationServiceTests
{
    private BasicOperationService service = new BasicOperationService();
    private const int a = 6;
    private const int b = 3;

    [Fact]
    public void AddMustReturnCorrectSum()
    {
        // Arrange
        var basicOperations = new BasicOperationService();
        var num1 = 6;
        var num2 = 3;
        var expected = 9;

        // Act
        var result = basicOperations.Add(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AddMustReturnCorrectSum_SetupInClass()
    {
        // Arrange
        var expected = 9;

        // Act
        var result = service.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SubtractMustReturnCorrectResult()
    {
        // Arrange
        var expected = 3;

        // Act
        var result = service.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MultiplyMustReturnCorrectResult()
    {
        // Arrange
        var expected = 18;

        // Act
        var result = service.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideMustReturnCorrectResult()
    {
        // Arrange
        var expected = 2;

        // Act
        var result = service.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideByZeroMustReturnException()
    {
        // Arrange
        var zero = 0;

        // Act
        var exception = Assert.Throws<DivideByZeroException>(() => service.Divide(a, zero));

        // Assert
        Assert.Equal("Não pode dividir por zero", exception.Message);
    }

    [Fact]
    public void DivideWithDoubleResultMustReturnCorrectIntResult()
    {
        // Arrange
        var x = 1;
        var y = 2;
        var expected = 0.5;

        // Act
        var result = service.Divide(x, y);

        // Assert
        Assert.Equal(expected, result);
    }
}
