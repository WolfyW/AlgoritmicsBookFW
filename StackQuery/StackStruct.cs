using System;

namespace AlgoritmicsBookFW.StackQuery
{
    class StackStruct<T> : BaseStruct<T>
    {
        public StackStruct(int maxSize) : base (maxSize)
        {    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public override void Insert(T item)
        {
            if (nElements == a.Length)
                throw new OverflowException("Стек переполнен");
            a[++current] = item;
            nElements++;
        }

        public override T Remove()
        {
            if (nElements == 0)
                throw new Exception("Стек пуст");
            T temp = a[current--];
            nElements--;
            return temp;
        }

        public override T Peek()
        {
            if (nElements == 0)
                throw new Exception("Стек пуст");
            return a[current];
        }
    }
}
