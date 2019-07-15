using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.LinkedList
{
    public class LinkListEnd<T>
    {
        private NodeOne<T> _first;
        private NodeOne<T> _last;

        public LinkListEnd()
        {
            _first = null;
            _last = null;
        }

        public void AddFirst(T item)
        {
            var node = new NodeOne<T>(item);
            if (IsEmpty())
                _last = node;
            node.Next = _first;
            _first = node;
        }

        public void AddLast(T item)
        {
            var node = new NodeOne<T>(item);
            if (IsEmpty())
                _first = node;

            _last.Next = node;
            _last = node;
        }

        public T DeleteFirst()
        {
            if (IsEmpty())
                throw new Exception("Пустой список");

            var node = _first;
            _first = _first.Next;
            if (IsEmpty())
                _last = null;
            return node.Data;
        }

        public void DeleteKey(T key)
        {
            if (IsEmpty())
                throw new Exception("Пустой список");

            var nodeCurrent = _first;
            var nodePrevios = _first;

            while (!IsEmpty())
            {
                if (nodeCurrent.Data.Equals(key))
                {
                    if (nodeCurrent == _first)
                        _first = _first.Next;
                    else if (nodeCurrent == _last)
                        _last = nodePrevios;
                    else
                        nodePrevios.Next = nodeCurrent.Next;
                    break;
                }
                nodePrevios = nodeCurrent;
                nodeCurrent = nodeCurrent.Next;
            }
        }

        public T PeekLast()
        {
            return _last.Data;
        }

        public T PeekFirst()
        {
            return _first.Data;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        public void Display()
        {
            var node = _first;

            while (node != null)
            {
                Console.Write(node.ToString());
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
