namespace TestProject;

public class Calendar{
    public bool IsLeapYear(int year){
        if(year % 100 == 0) return false;
        return year % 4 == 0;
    }
}