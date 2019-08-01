using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                First.Previus = newNode;
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
            newNode.Previus = _last;
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
                First.Next.Previus = null;

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
                _last.Previus.Next = null;
            _last = _last.Previus;

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
                node.Previus.Next = node.Next;

            if (node == _last)
                _last = node.Previus;
            else
                node.Next.Previus = node.Previus;
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
