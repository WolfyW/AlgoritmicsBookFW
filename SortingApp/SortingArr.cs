using System;

namespace AlgoritmicsBookFW.SortingApp
{
    public class SortingArr
    {
        public bool IsInit { get; private set; }

        public SortingArr()
        {
            IsInit = true;
        }

        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            MergeSort<T> sort = new MergeSort<T>(array);
            sort.Sort();
            return sort.ToArray();
        }
    }
}
