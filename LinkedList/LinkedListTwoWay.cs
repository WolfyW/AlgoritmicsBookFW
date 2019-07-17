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
            NodeTwo<T> newNode = new NodeTwo<T>(item);

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
            NodeTwo<T> newNode = new NodeTwo<T>(item);

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

        public void RemoveFirst()
        {
            
        }

        public void RemoveLast()
        {
            
        }

        public void RemoveByKey(T key)
        {
            
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
