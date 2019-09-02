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
            if (right - left <= 0) // Если размер равен 1,
                return; // массив отсортирован.
            else // Для размера 2 и более
            {
                // Разбиение диапазона
                long pivot = a[right];
                int partition = PartitionIt(left, right, pivot);
                RecQuickSort(left, partition - 1); // Сортировка левой части
                RecQuickSort(partition + 1, right); // Сортировка правой части
            }
        }

        private int PartitionIt(int left, int right, long pivot)
        {
            int leftPtr = left - 1;
            int rigthPtr = right;

            while (true)
            {
                while (a[++leftPtr] < pivot) ;
                while (rigthPtr > 0 && a[--rigthPtr] > pivot) ;

                if (leftPtr >= rigthPtr)
                    break;
                else
                    Swap(leftPtr, rigthPtr);
            }
            Swap(leftPtr, right);
            return leftPtr;
        }

        private void Swap(int dex1, int dex2) // Перестановка двух элементов
        {
            long temp = a[dex1]; // A копируется в temp
            a[dex1] = a[dex2]; // B копируется в A
            a[dex2] = temp; // temp копируется в B
        }
    }
}
