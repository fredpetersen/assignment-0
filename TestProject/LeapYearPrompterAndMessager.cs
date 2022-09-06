namespace TestProject;

public class LeapYearPrompterAndMessager
{
    private YearRetriever yearRetriever;
    public LeapYearPrompterAndMessager(YearRetriever retriever)
    {
        yearRetriever = retriever;
    }

    public void run(){
        var calendar = new Calendar();
        var year = int.Parse(yearRetriever.GetYear());
        var isLeapYear = calendar.IsLeapYear(year);

        if(isLeapYear)
        {
            Console.WriteLine("yay");
        } else 
        {
            Console.WriteLine("nay");
        }
    }
}