using Xunit;
using SonarDemo;
namespace SonarDemo.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var class1 = new Class1();
        var result = class1.function1();
        Assert.Equal(true, result);
    }

    [Theory]
    [InlineData(false, 1)]
    [InlineData(false, 2)]
    [InlineData(true, 3)]
    [InlineData(false, 4)]
    [InlineData(false, 5)]
    [InlineData(true, 6)]
    [InlineData(false, 7)]
    [InlineData(false, 8)]
    [InlineData(true, 9)]
    [InlineData(false, 10)]
    public void Test2(bool expected, int number)
    {
        var class1 = new Class1();
        var result = class1.CanModBy3(number);
        Assert.Equal(expected,result);
    }
}