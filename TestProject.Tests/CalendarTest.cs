namespace TestProject.Tests;

public class CalendarTest
{
    [Fact]
    public void IsLeapYear_given_2004_returns_true()
    {
        var sut = new Calendar();

        var result = sut.IsLeapYear(2004);

        result.Should().Be(true);
    }

    [Fact]
    public void IsLeapYear_given_2001_returns_false()
    {
        var sut = new Calendar();

        var result = sut.IsLeapYear(2001);
        
        result.Should().Be(false);
    }

    [Fact]
    public void IsLeapYear_given_1800_returns_false()
    {
        var sut = new Calendar();

        var result = sut.IsLeapYear(1800);

        result.Should().Be(false);
    }
}