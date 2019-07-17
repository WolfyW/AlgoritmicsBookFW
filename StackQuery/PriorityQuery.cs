using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class PriorityQuery<T> : BaseStruct<T> where T : IComparable<T>
    {
        public PriorityQuery(int maxSize) : base(maxSize)
        { }

        public override void Insert(T item)
        {
            if (NElements == a.Length)
                throw new Exception("Переполнение");
            if (NElements == 0)
                a[NElements++] = item;
            else
            {
                int i = NElements - 1;
                for (; i >= 0; i--)
                {
                    if (item.CompareTo(a[i]) > 0)
                        a[i + 1] = a[i];
                    else
                        break;
                }
                a[i + 1] = item;
                NElements++;
            }
        }

        public override T Peek()
        {
            if (NElements == 0)
                throw new Exception("Очередь пуста");
            return a[NElements];
        }

        public override T Remove()
        {
            if (NElements == 0)
                throw new Exception("Очередь пуста");
            return a[--NElements];
        }
    }
}
