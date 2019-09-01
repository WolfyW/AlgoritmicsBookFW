using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.SortingApp
{
    public class ShellSort<T> : HArray<T> where T : IComparable<T>
    {
        public ShellSort(int maxElemnts) : base(maxElemnts)
        { }

        public ShellSort(T[] array) : base(array)
        { }

        public override void Sort()
        {
            int inner, outer;
            T temp;
            int h = 1;
            while (h <= nElements / 3)
                h = h * 3 + 1;

            while (h > 0)
            {
                for (outer = h; outer < nElements; outer++)
                {
                    temp = a[outer];
                    inner = outer;
                    while (inner > h - 1 && a[inner - h].CompareTo(temp) >= 0)
                    {
                        a[inner] = a[inner - h];
                        inner -= h;
                    }
                    a[inner] = temp;
                }
                h = (h - 1) / 3;
            }
        }
    }
}
