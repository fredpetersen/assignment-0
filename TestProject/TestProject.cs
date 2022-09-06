namespace TestProject;

class TestProject{

    private static void Main(string[] args)
    {
        new LeapYearPrompterAndMessager(new ConsoleYearRetriever()).run();

    }
}