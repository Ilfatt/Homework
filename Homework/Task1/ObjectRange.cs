namespace Task1;

public class ObjectRange
{
    public ObjectRange(object rangeStart, object rangeEnd)
    {
        RangeStart = rangeStart;
        RangeEnd = rangeEnd;
    }
    public object RangeStart { get; set; }
    public object RangeEnd { get; set; }

    public bool InRange(object value)
    {
        if (Comparer<object>.Default.Compare(RangeStart, value) >= 0 && Comparer<object>.Default.Compare(RangeEnd, value) <= 0
            || Comparer<object>.Default.Compare(RangeStart, value) == 0 || Comparer<object>.Default.Compare(RangeEnd, value) == 0)
        {
            Console.WriteLine($"{value} входит в промежуток от {RangeStart} до {RangeEnd}");
        }
        else
        {
            Console.WriteLine($"{value} не входит в промежуток от {RangeStart} до {RangeEnd}");
        }

        return Comparer<object>.Default.Compare(RangeStart, value) <= 0 && Comparer<object>.Default.Compare(RangeEnd, value) >= 0
               || Comparer<object>.Default.Compare(RangeStart, value) == 0 || Comparer<object>.Default.Compare(RangeEnd, value) == 0;
    }
}