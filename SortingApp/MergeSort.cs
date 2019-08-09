using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.SortingApp
{
    public class MergeSort<T> : HArray<T> where T : IComparable<T>
    {
        public MergeSort(int maxSize) : base(maxSize)
        {  }
        public override void Sort()
        {
            throw new NotImplementedException();
        }

        private void Merge(T[] arrayA, int sizeA, T[] arrayB, int sizeB, T[] arrayC)
        {
            int aDex = 0;
            int bDex = 0;
            int cDex = 0;

            while (aDex < sizeA && bDex < sizeB)
            {
                if (arrayA[aDex].CompareTo(arrayB[bDex]) < 0)
                    arrayC[cDex++] = arrayA[aDex++];
                else
                    arrayC[cDex++] = arrayB[bDex];
            }
            while (aDex < sizeA)
                arrayC[cDex++] = arrayA[aDex];
            while (bDex < sizeB)
                arrayC[cDex++] = arrayB[bDex];
        }
    }
}
