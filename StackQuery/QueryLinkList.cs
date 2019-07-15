using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmicsBookFW.Interface;
using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.StackQuery
{
    class QueryLinkList<T> : ISQ<T>
    {
        private readonly LinkListEnd<T> _linkList;

        public QueryLinkList()
        {
            _linkList = new LinkListEnd<T>();
        }

        public void Insert(T item)
        {
            _linkList.AddLast(item);
        }

        public T Peek()
        {
            return _linkList.PeekFirst();
        }

        public T Remove()
        {
            return _linkList.DeleteFirst();
        }

        public void Display()
        {
            _linkList.Display();
        }

        public bool IsEmpty()
        {
            return _linkList.IsEmpty();
        }

    }
}
