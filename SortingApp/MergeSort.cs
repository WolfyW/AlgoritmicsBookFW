using System;

namespace AlgoritmicsBookFW.SortingApp
{
    public class MergeSort<T> : HArray<T> where T : IComparable<T>
    {
        public MergeSort(int maxSize) : base(maxSize)
        { }

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

        public T[] SortOther()
        {
            T[] temp = new T[a.Length];
            MergeSortOtherImplemantation(temp, 0, a.Length - 1);
            return a;
        }

        private void MergeSortOtherImplemantation(T[] workCopy, int lowBound, int upperBoud)
        {
            int middle = (lowBound + upperBoud) / 2;
            if (lowBound == upperBoud)
                return;
            MergeSortOtherImplemantation(workCopy, lowBound, middle);
            MergeSortOtherImplemantation(workCopy, middle + 1, upperBoud);
            MergeOther(workCopy, lowBound, middle +1, upperBoud);
        }

        private void MergeOther(T[] tempA, int low, int middle, int upper)
        {
            int ptrA = low; // Начало первого массива
            int mid = middle - 1; // Окончание первого массива
            int ptrB = middle; // Начало второго массива
            int n = upper - low + 1; // Количество элементов
            int ptrC = 0; // индексация врменного массива

            while (ptrA <= mid && ptrB <= upper)
            {
                if (a[ptrA].CompareTo(a[ptrB]) < 0)
                    tempA[ptrC++] = a[ptrA++];
                else
                    tempA[ptrC++] = a[ptrB++];
            }

            while (ptrA <= mid)
            {
                tempA[ptrC++] = a[ptrA++];
            }

            while (ptrB <= upper)
            {
                tempA[ptrC++] = a[ptrB++];
            }

            for (int i = 0; i < n; i++)
                a[low + i] = tempA[i];
        }
    }
}
