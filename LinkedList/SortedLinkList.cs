using System;
using AlgoritmicsBookFW.LinkedList.Nodes;

namespace AlgoritmicsBookFW.LinkedList
{
    class SortedLinkList<T> where T : IComparable<T>
    {
        private NodeOne<T> _first;

        public void Add(T item)
        {
            var newNode = new NodeOne<T>(item);
            if (IsEmpty() || _first.Data.CompareTo(newNode.Data) >= 0)
            {
                newNode.Next = _first;
                _first = newNode;
            }
            else
            {
                var node = _first;
                while (node.Next != null && node.Next.Data.CompareTo(newNode.Data) < 0)
                {
                    node = node.Next;
                }
                newNode.Next = node.Next;
                node.Next = newNode;
            }
        }

        public T RemoveFirst()
        {
            if (_first == null)
                throw new Exception("Список пуст");

            var node = _first;
            _first = _first.Next;

            return node.Data;
        }

        public T Peek()
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
                Console.Write(_first.Data);
                node = node.Next;
            }
        }

    }
}
