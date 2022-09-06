namespace TestProject;

public class ConsoleYearRetriever : YearRetriever
{
    public override string GetYear()
    {
        return Console.ReadLine();
    }
}