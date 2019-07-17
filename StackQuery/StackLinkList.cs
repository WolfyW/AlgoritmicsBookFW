using AlgoritmicsBookFW.Interface;
using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.StackQuery
{
    public class StackLinkList<T> : ISQ<T>
    {
        private readonly LinkList<T> _linkList;

        public StackLinkList()
        {
            _linkList = new LinkList<T>();
        }

        public void Insert(T item)
        {
            _linkList.AddFirst(item);
        }

        public T Peek()
        {
            return _linkList.Peek();
        }

        public T Remove()
        {
            return _linkList.DeleteFirst();
        }

        public bool IsEmpty()
        {
            return _linkList.IsEmpty();
        }

        public void Dislplay()
        {
            _linkList.Display();
        }
    }
}
