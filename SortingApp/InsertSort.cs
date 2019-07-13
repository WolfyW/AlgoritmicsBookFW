using System;

namespace AlgoritmicsBookFW.SortingApp
{
    public class InsertSort : HArray<long>
    {
        public InsertSort(int maxItem) : base(maxItem)
        { }

        public override void Sort()
        {
            int outer, inner;
            for (outer = 1; outer < nElements; outer++)
            {
                long temp = a[outer];
                inner = outer;
                while(inner > 0 && a[inner - 1] >= temp )
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

            if (a.Length % 2 == 1)
                return a[a.Length / 2];
            else
                return 0.5 * (a[a.Length / 2 - 1] + a[a.Length / 2]);
        }

        public void Nodups()
        {
            if (!IsSorted)
                throw new Exception();

            int p = 0;
            int count = 0;
            for (int i = 1; i < nElements; i++)
            {
                while (a[p] == a[i])
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
