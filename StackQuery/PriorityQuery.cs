using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class PriorityQuery<T> : BaseStruct<T> where T : IComparable<T>
    {
        public PriorityQuery(int maxSize) : base(maxSize)
        { }

        public override void Insert(T item)
        {
            if (nElements == a.Length)
                throw new Exception("Переполнение");
            if (nElements == 0)
                a[nElements++] = item;
            else
            {
                int i = nElements;
                for (; i >= 0; i--)
                {
                    if (item.CompareTo(a[i]) > 0)
                        a[i + 1] = a[i];
                    else
                        break;
                }
                a[i] = item;
                nElements++;
            }
        }

        public override T Peek()
        {
            if (nElements == 0)
                throw new Exception("Очередь пуста");
            return a[nElements];
        }

        public override T Remove()
        {
            if (nElements == 0)
                throw new Exception("Очередь пуста");
            return a[--nElements];
        }
    }
}
