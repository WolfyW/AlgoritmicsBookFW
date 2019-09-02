namespace AlgoritmicsBookFW.Interface
{
    public interface ITree<T> : IBaseStruct<T>
    {
        bool Find(T item);
        void Display();
    }
}
