namespace AlgoritmicsBookFW.LinkedList.Iterators
{
    public interface IIterator<T>
    {
        void MoveNext();
        T GetCurrent();
        void Reset();
    }
}
