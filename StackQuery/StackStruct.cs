using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class StackStruct<T> : BaseStruct<T>
    {
        public StackStruct(int maxSize) : base (maxSize)
        {    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public override void Insert(T item)
        {
            if (NElements == a.Length)
                throw new OverflowException("Стек переполнен");
            a[++Current] = item;
            NElements++;
        }

        public override T Remove()
        {
            if (NElements == 0)
                throw new Exception("Стек пуст");
            T temp = a[Current--];
            NElements--;
            return temp;
        }

        public override T Peek()
        {
            if (NElements == 0)
                throw new Exception("Стек пуст");
            return a[Current];
        }
    }
}
