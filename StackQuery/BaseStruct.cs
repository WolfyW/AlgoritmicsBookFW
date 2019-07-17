using AlgoritmicsBookFW.Interface;

namespace AlgoritmicsBookFW.StackQuery
{
    public abstract class BaseStruct<T> : ISQ<T>
    {
        protected int NElements;
        protected readonly T[] a;
        protected int Current;

        protected BaseStruct(int maxElemets)
        {
            NElements = 0;
            a = new T[maxElemets];
            Current = -1;
        }

        public abstract void Insert(T item);

        public abstract T Peek();

        public abstract T Remove();

        public virtual bool IsEmpty()
        {
            return NElements == 0;
        }

        public virtual bool IsFull()
        {
            return a.Length == NElements;
        }
    }
}
