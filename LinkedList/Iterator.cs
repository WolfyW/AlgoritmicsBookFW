using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.Iterator
{
    public interface IIterator
    {

    }

    public class Iterator<T>
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

        public void MoveNext()
        {
            _priviois = _current;
            _current = _current.Next;
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
