using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class DequeryStruct<T>
    {
        int nElements;
        T[] a;

        int left;
        int right;

        public DequeryStruct(int maxSize)
        {
            a = new T[maxSize];
            left = -1;
            right = -1;
        }

        public void InsertLeft(T item)
        {
            if (nElements == a.Length)
                throw new Exception("Заполнено");

            if (left == -1 || IsEmpty())
            {
                left = 0;
                right = 0;
            }
            else if (!IsEmpty() && left == 0)
                left = a.Length - 1;
            else
                left--;

            nElements++;
            a[left] = item;
        }

        public void InsertRight(T item)
        {
            if (nElements == a.Length)
                throw new Exception("Заполнено");

            if (right == a.Length -1)
                right = -1;

            if (IsEmpty())
            {
                left = 0;
                right = -1;
            }

            nElements++;
            a[++right] = item;
        }

        public T RemoveLeft()
        {
            if (IsEmpty())
                throw new Exception("Пусто");

            T temp = a[left];
            a[left] = default(T);

            if (left == a.Length - 1)
                left = 0;
            else
                left++;

            nElements--;
            return temp;

        }

        public T RemoveRight()
        {
            if (IsEmpty())
                throw new Exception("Пусто");

            T temp = a[right];
            a[right] = default(T);

            if (right == 0)
                right = a.Length - 1;
            else
                right--;

            nElements--;
            return temp;
        }

        public bool IsEmpty()
        {
            return nElements == 0;
        }

        public bool IsFull()
        {
            return nElements == a.Length;
        }
    }
}
