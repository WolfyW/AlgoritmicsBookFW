using System;
using AlgoritmicsBookFW.LinkedList.Iterator;
using AlgoritmicsBookFW.LinkedList.Nodes;

namespace AlgoritmicsBookFW.LinkedList
{
    public class LinkedListTwoWay<T>
    {
        public NodeTwo<T> First { get; private set; }
        private NodeTwo<T> _last;

        public void AddFirst(T item)
        {
            var newNode = new NodeTwo<T>(item);

            if (IsEmpty())
            {
                _last = newNode;
            }
            else
            {
                First.Previous = newNode;
            }
            newNode.Next = First;
            First = newNode;
        }

        public void AddLast(T item)
        {
            var newNode = new NodeTwo<T>(item);

            if (IsEmpty())
            {
                First = newNode;
            }
            else
            {
                _last.Next = newNode;
            }
            newNode.Previous = _last;
            _last = newNode;
        }

        public T RemoveFirst()
        {
            if (IsEmpty())
                throw new Exception("Список пуст");
            var node = First;

            if (First.Next == null)
                _last = null;
            else
                First.Next.Previous = null;

            First = First.Next;

            return node.Data;
        }

        public T RemoveLast()
        {
            if (IsEmpty())
                throw new Exception("Список пуст");

            var node = _last;

            if (First.Next == null)
                First = null;
            else
                _last.Previous.Next = null;
            _last = _last.Previous;

            return node.Data;
        }

        public void RemoveKey(T key)
        {
            if (IsEmpty())
                throw new Exception("Список пуст");
            var node = First;

            while (!node.Data.Equals(key))
            {
                node = node.Next;
                if (node == null)
                    return;
            }
            if (node == First)
                First = First.Next;
            else
                node.Previous.Next = node.Next;

            if (node == _last)
                _last = node.Previous;
            else
                node.Next.Previous = node.Previous;
        }

        public bool IsEmpty()
        {
            return First == null;
        }

        public void Display()
        {
            NodeTwo<T> node = First;
            while (node != null)
            {
                Console.WriteLine(node);
                node = node.Next;
            }
        }

        public IIterator<T> GetIterator()
        {
            return new IteratorTwoList<T>(this);
        }
    }
}
