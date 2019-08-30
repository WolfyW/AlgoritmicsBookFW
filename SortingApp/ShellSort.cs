using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.SortingApp
{
    class ShellSort<T> : HArray<T> where T : IComparable<T>
    {
        public ShellSort(int maxElemnts) : base(maxElemnts)
        { }

        public ShellSort(T[] array) : base(array)
        { }

        public override void Sort()
        {
            throw new NotImplementedException();


        }
    }
}
