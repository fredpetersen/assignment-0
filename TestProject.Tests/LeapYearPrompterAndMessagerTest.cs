namespace TestProject.Tests;

public class TestProjectTest
{
    public class TestYearRetriever : YearRetriever
    {
        private string year;
        public TestYearRetriever(string givenYear){
            year = givenYear;
        }
        public override string GetYear()
        {
            return year;
        }
    }


    [Fact]
    public void LeapYearPrompterAndMessager_when_given_1999_prints_nay()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var yearRetriever = new TestYearRetriever("1999");
        var sut = new LeapYearPrompterAndMessager(yearRetriever);

        sut.run();

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void LeapYearPrompterAndMessager_when_given_2000_prints_yay()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var yearRetriever = new TestYearRetriever("2000");
        var sut = new LeapYearPrompterAndMessager(yearRetriever);

        sut.run();

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void LeapYearPrompterAndMessager_when_given_non_year_string_throws_ArgumentException()
    {
        var yearRetriever = new TestYearRetriever("non-year value");
        var sut = new LeapYearPrompterAndMessager(yearRetriever);

        var action = () => sut.run();

        action.Should().Throw<ArgumentException>().WithParameterName("year").WithMessage("String could not be parsed to int");
    }
}