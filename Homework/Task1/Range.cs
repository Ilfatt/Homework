namespace Task1
{
    public struct Range<T> : IComparable<T>
    {
        public Range(T from, T to)
        {
            From = from;
            To = to;
        }
        public T From { get; set; }
        public T To { get; set; }

        public bool HasValue(T value)
        {
            if (Comparer<T>.Default.Compare(From, value) >= 0 && Comparer<T>.Default.Compare(To, value) <= 0
                || Comparer<T>.Default.Compare(From, value) == 0 || Comparer<T>.Default.Compare(To, value) == 0)
            {
                Console.WriteLine($"{value} входит в промежуток от {From} до {To}");
            }
            else
            {
                Console.WriteLine($"{value} не входит в промежуток от {From} до {To}");
            }
            return Comparer<T>.Default.Compare(From, value) <= 0 && Comparer<T>.Default.Compare(To, value) >= 0
                   || Comparer<T>.Default.Compare(From, value) == 0 || Comparer<T>.Default.Compare(To, value) == 0;
        }
    }
}