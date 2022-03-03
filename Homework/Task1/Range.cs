namespace Task1
{
    public struct Range<T> : IRange<T>
    {
        public Range(T rangeStart, T rangeEnd)
        {
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
        }
        public T RangeStart { get; set; }
        public T RangeEnd { get; set; }

        public bool InRange(T value)
        {
            if (Comparer<T>.Default.Compare(RangeStart, value) >= 0 && Comparer<T>.Default.Compare(RangeEnd, value) <= 0
                || Comparer<T>.Default.Compare(RangeStart, value) == 0 || Comparer<T>.Default.Compare(RangeEnd, value) == 0)
            {
                Console.WriteLine($"{value} входит в промежуток от {RangeStart} до {RangeEnd}");
            }
            else
            {
                Console.WriteLine($"{value} не входит в промежуток от {RangeStart} до {RangeEnd}");
            }
            return Comparer<T>.Default.Compare(RangeStart, value) <= 0 && Comparer<T>.Default.Compare(RangeEnd, value) >= 0
                   || Comparer<T>.Default.Compare(RangeStart, value) == 0 || Comparer<T>.Default.Compare(RangeEnd, value) == 0;
        }
    }
}