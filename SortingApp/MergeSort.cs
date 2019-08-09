using System;

namespace AlgoritmicsBookFW.SortingApp
{
    public class MergeSort<T> : HArray<T> where T : IComparable<T>
    {
        public MergeSort(int maxSize) : base(maxSize)
        {  }
        public override void Sort()
        {
            T[] workSpace = new T[nElements];
            recMergeSort(workSpace, 0, nElements - 1);
        }

        private void recMergeSort(T[] workSpace, int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
                return;
            int mid = (lowerBound + upperBound) / 2;
            recMergeSort(workSpace, lowerBound, mid);
            recMergeSort(workSpace, mid + 1, upperBound);
            Merge(workSpace, lowerBound, mid + 1, upperBound);
        }

        private void Merge(T[] workSpace, int lowPtr, int highPtr, int upperBound)
        {
            int j = 0;
            int lowerBound = lowPtr;
            int mid = highPtr - 1;
            int n = upperBound - lowerBound + 1;
            while (lowPtr <= mid && highPtr <= upperBound)
            {
                if (a[lowPtr].CompareTo(a[highPtr]) < 0)
                    workSpace[j++] = a[lowPtr++];
                else
                    workSpace[j++] = a[highPtr++];
            }

            while (lowPtr <= mid)
                workSpace[j++] = a[lowPtr++];

            while (highPtr <= upperBound)
                workSpace[j++] = a[highPtr++];

            for (j = 0; j < n; j++)
                a[lowerBound + j] = workSpace[j];
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
