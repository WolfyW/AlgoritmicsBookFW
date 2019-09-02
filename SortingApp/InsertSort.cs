using System;

namespace AlgoritmicsBookFW.SortingApp
{
    public class InsertSort<T> : HArray<T> where T : IComparable<T>
    {
        public InsertSort(int maxItem) : base(maxItem)
        { }

        public override void Sort()
        {
            int outer, inner;
            for (outer = 1; outer < nElements; outer++)
            {
                T temp = a[outer];
                inner = outer;
                while(inner > 0 && a[inner - 1].CompareTo(temp) >= 0)
                {
                    a[inner] = a[inner - 1];
                    inner--;
                }
                a[inner] = temp;
            }
            IsSorted = true;
        }

        public double Median()
        {
            if (!IsSorted)
                throw new Exception();

            dynamic t;

            if (this is InsertSort<long>)
            {
                t = a as long[];
            }
            else if (this is InsertSort<int>)
            {
                t = a as int[];
            }
            else if (this is InsertSort<double>)
            {
                t = a as double[];
            }
            else
                throw new Exception();


            if (t.Length % 2 == 1)
                return t[t.Length / 2];
            else
                return 0.5 * (t[t.Length / 2 - 1] + t[t.Length / 2]);
        }

        public void Nodups()
        {
            if (!IsSorted)
                throw new Exception();

            int p = 0;
            int count = 0;
            for (int i = 1; i < nElements; i++)
            {
                while (a[p].Equals(a[i]))
                {
                    count++;
                    i++;
                }
                Swap(p + 1, i);
                p++;
            }
            nElements -= count;
        }
    }
}
