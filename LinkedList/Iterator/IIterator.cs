namespace AlgoritmicsBookFW.LinkedList.Iterator
{
    public interface IIterator<T>
    {
        bool MoveNext();
        T GetCurrent();
        bool AtEnd();
        void AddAfter(T item);
        void AddBefore(T item);
        void Reset();
    }
}
