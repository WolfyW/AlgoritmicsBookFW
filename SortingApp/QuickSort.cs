using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.SortingApp
{
    public class QuickSort : HArray<long>
    {
        public QuickSort(int maxElemnts) : base(maxElemnts)
        { }

        public QuickSort(long[] array) : base(array)
        { }

        public override void Sort()
        {
            RecQuickSort(0, nElements - 1);
        }

        private void RecQuickSort(int left, int right)
        {
            int size = right - left + 1;
            if (size < 10)
            {
                InsertSort(left, right);
            }
            else 
            {
                long pivot = Median(left, right);
                int partition = PartitionIt(left, right, pivot);
                RecQuickSort(left, partition - 1); // Сортировка левой части
                RecQuickSort(partition + 1, right); // Сортировка правой части
            }
        }

        private long Median(int left, int right)
        {
            int center = (left + right) / 2;

            if (a[left] > a[center])
                Swap(left, center);

            if (a[left] > a[right])
                Swap(right, left);

            if (a[center] > a[right])
                Swap(right, center);

            Swap(center, right - 1);
            return a[right - 1];
        }

        private int PartitionIt(int left, int right, long pivot)
        {
            int leftPtr = left;
            int rigthPtr = right - 1;

            while (true)
            {
                while (a[++leftPtr] < pivot) ;
                while (a[--rigthPtr] > pivot) ;

                if (leftPtr >= rigthPtr)
                    break;
                else
                    Swap(leftPtr, rigthPtr);
            }
            Swap(leftPtr, right - 1);
            return leftPtr;
        }

        private void InsertSort(int left, int right)
        {
            int outer, inner;
            for (outer = left + 1; outer < right; outer++)
            {
                long temp = a[outer];
                inner = outer;
                while (inner > left && a[inner - 1] >= temp)
                {
                    a[inner] = a[inner - 1];
                    inner--;
                }
                a[inner] = temp;
            }
            IsSorted = true;
        }

        private void ManualSort(int left, int right)
        {
            int size = right - left + 1;
            int center = right - 1;
            if (size <= 1)
                return;
            if (size == 2)
            {
                if (a[left] > a[right])
                    Swap(left, right);
            }
            else
            {
                if (a[left] > a[center])
                    Swap(left, center);
                if (a[left] > a[right])
                    Swap(left, right);
                if (a[center] > a[right])
                    Swap(center, right);
            }
        }

        private void Swap(int dex1, int dex2) // Перестановка двух элементов
        {
            long temp = a[dex1]; // A копируется в temp
            a[dex1] = a[dex2]; // B копируется в A
            a[dex2] = temp; // temp копируется в B
        }
    }
}
