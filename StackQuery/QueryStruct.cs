using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class QueryStruct<T> : BaseStruct<T>
    {
        private int _end;

        public QueryStruct(int maxSize) : base(maxSize)
        {
            _end = 0;
        }

        public override void Insert(T item)
        {
            if (NElements == a.Length)
                throw new Exception("Очередь заполнена");

            if (Current == a.Length - 1 && _end != 0)
                Current = -1;

            a[++Current] = item;
            NElements++;
        }

        public override T Peek()
        {
            if (NElements == 0)
                throw new Exception("Очередь пуста");

            return a[_end];
        }

        public override T Remove()
        {
            if (NElements == 0)
                throw new Exception("Очередь пуста");

            T temp = a[_end];
            _end++;

            if (_end == a.Length)
                _end = 0;

            NElements--;

            return temp;
        }

        public void Display()
        {
            int index = _end;
            for (int i = 0; i < NElements; i++)
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
