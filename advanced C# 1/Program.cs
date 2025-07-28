namespace advanced_C__1
{
    #region Q1
    //class OptimizedBubbleSort
    //{
    //    static void BubbleSort(int[] array)
    //    {
    //        int n = array.Length;
    //        bool swapped;
    //
    //        for (int i = 0; i < n - 1; i++)
    //        {
    //            swapped = false;
    //
    //            for (int j = 0; j < n - i - 1; j++)
    //            {
    //                if (array[j] > array[j + 1])
    //                {
    //                    int temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //
    //                    swapped = true;
    //                }
    //            }
    //            if (!swapped)
    //                break;
    //        }
    //    }
    //
    //    static void Main()
    //    {
    //        int[] data = { 64, 34, 25, 12, 22, 11, 90 };
    //        Console.WriteLine("Original Array:");
    //        Console.WriteLine(string.Join(", ", data));
    //
    //        BubbleSort(data);
    //
    //        Console.WriteLine("\nSorted Array:");
    //        Console.WriteLine(string.Join(", ", data));
    //    }
    //}
    #endregion

    #region Q2
    //public class Range<T> where T : IComparable<T>
    //{
    //    public T Minimum { get; }
    //    public T Maximum { get; }
    //
    //    public Range(T minimum, T maximum)
    //    {
    //        if (minimum.CompareTo(maximum) > 0)
    //        {
    //            Console.WriteLine("Minimum should be less than or equal to Maximum.");
    //        }
    //
    //        Minimum = minimum;
    //        Maximum = maximum;
    //    }
    //
    //    public bool IsRange (T Value)
    //    {
    //        return Value.CompareTo(Minimum) >= 0 && Value.CompareTo(Maximum) <= 0;
    //    }
    //
    //    public double Length()
    //    {
    //        try
    //        {
    //            double min = Convert.ToDouble(Minimum);
    //            double max = Convert.ToDouble(Maximum);
    //            return max - min;
    //        }
    //        catch
    //        {
    //            Console.WriteLine("Length can only be calculated for numeric types.");
    //            return 0;
    //        }
    //    }
    //
    //    public override string ToString()
    //    {
    //        return $"Range IS :  [{Minimum} To {Maximum}]";
    //    }
    //
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q2
            //var intRange = new Range<int>(5, 15);
            //Console.WriteLine(intRange.IsRange(10));
            //Console.WriteLine(intRange.ToString());
            //Console.WriteLine(intRange.Length());
            //
            //Console.WriteLine("=====================");
            // 
            //var doubleRange = new Range<double>(36.3 , 80.2);
            //Console.WriteLine(doubleRange.IsRange(90));
            //Console.WriteLine(doubleRange.ToString());
            //Console.WriteLine(doubleRange.Length());
            #endregion
        }
    }
}
