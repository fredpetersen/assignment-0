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
        try{
            var year = int.Parse(yearRetriever.GetYear());
            var isLeapYear = calendar.IsLeapYear(year);

            if(isLeapYear)
            {
                Console.WriteLine("yay");
            } else 
            {
                Console.WriteLine("nay");
            }
        } catch(FormatException) {
            throw new ArgumentException("Year could not be parsed to int");
        }
    }
}