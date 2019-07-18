using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.LinkedList
{
    class LinkedListTwoWay<T>
    {
        private NodeTwo<T> _first;
        private NodeTwo<T> _last;

        public void InsertFirst(T item)
        {
            var newNode = new NodeTwo<T>(item);

            if (isEmpty())
            {
                _last = newNode;
            }
            else
            {
                _first.Previus = newNode;
            }
            newNode.Next = _first;
            _first = newNode;
        }

        public void InsertLast(T item)
        {
            var newNode = new NodeTwo<T>(item);

            if (isEmpty())
            {
                _first = newNode;
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
            if (isEmpty())
                throw new Exception("Список пуст");
            var node = _first;

            if (_first.Next == null)
                _last = null;
            else
                _first.Next.Previus = null;

            _first = _first.Next;

            return node.Data;
        }

        public T RemoveLast()
        {
            if (isEmpty())
                throw new Exception("Список пуст");

            var node = _last;

            if (_first.Next == null)
                _first = null;
            else
                _last.Previus.Next = null;
            _last = _last.Previus;

            return node.Data;
        }

        public void RemoveByKey(T key)
        {
            if (isEmpty())
                throw new Exception("Список пуст");
            var node = _first;

            while (!node.Data.Equals(key))
            {
                node = node.Next;
                if (node == null)
                    return;
            }
            if (node == _first)
                _first = _first.Next;
            else
                node.Previus.Next = node.Next;

            if (node == _last)
                _last = node.Previus;
            else
                node.Next.Previus = node.Previus;
        }

        public bool isEmpty()
        {
            return _first == null;
        }

        public void Display()
        {
            NodeTwo<T> node = _first;
            while (node != null)
            {
                Console.WriteLine(node);
                node = node.Next;
            }
        }
    }
}
