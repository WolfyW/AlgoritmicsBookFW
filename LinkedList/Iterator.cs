using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.Iterator
{
    public interface IIterator<T>
    {
        bool MoveNext();
        T GetCurrent();
        bool AtEnd();
        void AddAfter(T item);
        void AddBefore(T item);
    }

    public class Iterator<T> : IIterator<T>
    {
        private readonly LinkList<T> _list;
        private NodeOne<T> _current;
        private NodeOne<T> _priviois;

        public Iterator(LinkList<T> list)
        {
            _list = list;
            Reset();
        }

        public void Reset()
        {
            _current = _list.First;
        }

        public void AddBefore(T item)
        {
            NodeOne<T> newnode = new NodeOne<T>(item);
            _priviois.Next = newnode;
            newnode.Next = _current;
        }

        public void AddAfter(T item)
        {
            NodeOne<T> newNode = new NodeOne<T>(item);
            newNode.Next = _current.Next.Next;
            _current.Next = newNode;
        }

        public bool MoveNext()
        {
            _priviois = _current;
            _current = _current.Next;
            if (_current == null)
                return false;
            return true;
        }

        /// <internalonly/>
        public T GetCurrent()
        {
            return _current.Data;
        }

        public bool AtEnd()
        {
            return _current.Next == null;
        }
    }
}
