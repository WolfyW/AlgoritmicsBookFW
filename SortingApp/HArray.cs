using System;
using AlgoritmicsBookFW.Interface;

namespace AlgoritmicsBookFW.SortingApp
{
    public abstract class HArray<T> : IArray<T>
    {
        protected T[] a;
        protected int nElements;
        protected bool IsSorted = false;

        public HArray(int maxElemnts)
        {
            nElements = 0;
            a = new T[maxElemnts + 1];
        }

        public bool Remove(T item)
        {
            int i = -1;
            for (i = 0; i < nElements; i++)
            {
                if (a[i].Equals(item))
                    break;
            }

            if (i == nElements)
                return false;
            else
            {
                for (int j = i; j < nElements; j++)
                    a[j] = a[j + 1];
                nElements--;
                IsSorted = false;
                return true;
            }
        }

        public void Display()
        {
            for (int i = 0; i < nElements; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public bool Find(T item)
        {
            for (int i = 0; i < nElements; i++)
            {
                if (a[i].Equals(item))
                    return true;
            }
            return false;
        }

        public void Insert(T item)
        {
            a[nElements] = item;
            nElements++;
            IsSorted = false;
        }

        public int Count()
        {
            return nElements;
        }

        protected void Swap(int one, int two)
        {
            T temp = a[one];
            a[one] = a[two];
            a[two] = temp;
        }

        public abstract void Sort();
    }
}
