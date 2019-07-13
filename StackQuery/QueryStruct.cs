using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class QueryStruct<T> : BaseStruct<T>
    {
        protected int end;

        public QueryStruct(int maxSize) : base(maxSize)
        {
            end = 0;
        }

        public override void Insert(T item)
        {
            if (nElements == a.Length)
                throw new Exception("Очередь заполнена");

            if (current == a.Length - 1 && end != 0)
                current = -1;

            a[++current] = item;
            nElements++;
        }

        public override T Peek()
        {
            if (nElements == 0)
                throw new Exception("Очередь пуста");

            return a[end];
        }

        public override T Remove()
        {
            if (nElements == 0)
                throw new Exception("Очередь пуста");

            T temp = a[end];
            end++;

            if (end == a.Length)
                end = 0;

            nElements--;

            return temp;
        }

        public void Display()
        {
            int index = end;
            for (int i = 0; i < nElements; i++)
            {
                Console.Write(a[index] + " ");
                index++;
                if (index == a.Length)
                    index = 0;
            }
            Console.WriteLine();
        }
    }
}
