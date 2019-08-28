namespace AlgoritmicsBookFW.SortingApp
{
    public static class ArrayExetension
    {
        public static int[] SortArray(this int[] arr)
        {
            MergeSort<int> sort = new MergeSort<int>(arr);
            sort.Sort();
            return sort.ToArray();
        }

        public static long[] SortArray(this long[] arr)
        {
            MergeSort<long> sort = new MergeSort<long>(arr);
            sort.Sort();
            return sort.ToArray();
        }

        public static double[] SortArray(this double[] arr)
        {
            MergeSort<double> sort = new MergeSort<double>(arr);
            sort.Sort();
            return sort.ToArray();
        }
    }
}
