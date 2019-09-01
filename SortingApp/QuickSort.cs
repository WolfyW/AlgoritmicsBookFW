using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.SortingApp
{
    public class QuickSort<T> : HArray<T> where T : IComparable<T>
    {
        public QuickSort(int maxElemnts) : base(maxElemnts)
        {
        }

        public QuickSort(T[] array) : base(array)
        {
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }

        private void Partition()
        {

        }
    }
}
