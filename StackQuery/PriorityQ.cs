using System;

namespace AlgoritmicsBookFW.StackQuery
{
    /// <summary>
    /// Быстра вставка, меделнное извлечение
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityQ<T> : BaseStruct<T> where T : IComparable<T>
    {
        public PriorityQ(int maxElemets) : base(maxElemets)
        {
        }

        private PriorityQ<T> Clone()
        {
            var q = new PriorityQ<T>(a.Length);
            q.Current = Current;
            q.NElements = NElements;

            for (int i = 0; i < NElements; i++)
            {
                q.a[i] = a[i];
            }

            return q;
        }

        public override void Insert(T item)
        {
            if (NElements == a.Length)
                throw new Exception("Очередб переполнена");

            a[++Current] = item;
            NElements++;
        }

        public override T Remove()
        {
            if (NElements == 0)
                throw new Exception("Очередь пуста");

            int index = FindMin();

            T temp = a[index];

            for (int i = index; i < NElements - 1; i++)
            {
                a[index] = a[index + 1];
            }
            Current--;
            NElements--;

            return temp;
        }

        public override T Peek()
        {
            if (NElements == 0)
                throw new Exception("Очередь пуста");
            return a[FindMin()];
        }

        public void Display()
        {
            var q = Clone();
            while (!q.IsEmpty())
            {
                Console.Write(q.Remove());
            }
            Console.WriteLine();
        }

        private int FindMin()
        {
            int min = 0;

            for (int i = 0; i < NElements; i++)
            {
                if (a[min].CompareTo(a[i]) > 0)
                    min = i;
            }

            return min;
        }
    }
}
