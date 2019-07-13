using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.StackQuery
{
    class PriorityQ<T> : BaseStruct<T> where T : IComparable<T>
    {
        public PriorityQ(int maxElemets) : base(maxElemets)
        {
        }

        private PriorityQ<T> Clone()
        {
            var q = new PriorityQ<T>(a.Length);
            q.current = current;
            q.nElements = nElements;

            for (int i = 0; i < nElements; i++)
            {
                q.a[i] = a[i];
            }

            return q;
        }

        public override void Insert(T item)
        {
            if (nElements == a.Length)
                throw new Exception("Очередб переполнена");

            a[++current] = item;
            nElements++;
        }

        public override T Remove()
        {
            if (nElements == 0)
                throw new Exception("Очередь пуста");

            int index = FindMin();
            T temp = a[index];

            for (int i = index; i < nElements; i++)
            {
                a[index + 1] = a[index];
            }
            current--;
            nElements--;

            return temp;
        }

        public override T Peek()
        {
            if (nElements == 0)
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

            for (int i = 0; i < nElements; i++)
            {
                if (a[min].CompareTo(a[i]) < 0)
                    min = i;
            }

            return min;
        }
    }
}
