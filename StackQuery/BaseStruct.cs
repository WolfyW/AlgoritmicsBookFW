using AlgoritmicsBookFW.Interface;

namespace AlgoritmicsBookFW.StackQuery
{
    public abstract class BaseStruct<T> : ISQ<T>
    {
        protected int nElements;
        protected T[] a;
        protected int current;

        public BaseStruct(int maxElemets)
        {
            nElements = 0;
            a = new T[maxElemets];
            current = -1;
        }

        public abstract void Insert(T item);

        public abstract T Peek();

        public abstract T Remove();

        public virtual bool IsEmpty()
        {
            return nElements == 0;
        }
    }
}
