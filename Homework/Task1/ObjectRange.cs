namespace Task1;

public class ObjectRange
{
    public ObjectRange(object from, object to)
    {
        From = from;
        To = to;
    }
    public object From { get; set; }
    public object To { get; set; }

    public bool HasValue(object value)
    {
        if (Comparer<object>.Default.Compare(From, value) >= 0 && Comparer<object>.Default.Compare(To, value) <= 0
            || Comparer<object>.Default.Compare(From, value) == 0 || Comparer<object>.Default.Compare(To, value) == 0)
        {
            Console.WriteLine($"{value} входит в промежуток от {From} до {To}");
        }
        else
        {
            Console.WriteLine($"{value} не входит в промежуток от {From} до {To}");
        }

        return Comparer<object>.Default.Compare(From, value) <= 0 && Comparer<object>.Default.Compare(To, value) >= 0
               || Comparer<object>.Default.Compare(From, value) == 0 || Comparer<object>.Default.Compare(To, value) == 0;
    }
}