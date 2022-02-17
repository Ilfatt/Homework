namespace Task1;

public class Program
{
    public static void Main()
    {
        Range<int> interval = new Range<int>(1, 5);
        interval.HasValue(3);
        ObjectRange objectInterval = new ObjectRange((double)1, 1.5);
        objectInterval.InRange(1.25);
    }
    
}