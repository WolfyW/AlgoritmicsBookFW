﻿using System;

namespace AlgoritmicsBookFW.LinkedList
{
    public class LinkList<T>
    {
        private NodeOne<T> _first;

        public LinkList()
        {
            _first = null;
        }

        public void AddFirst(T item)
        {
            var node = new NodeOne<T>(item);
            node.Next = _first;
            _first = node;
        }

        public T DeleteFirst()
        {
            if (IsEmpty())
                throw new Exception("Пустой список");

            var temp = _first;
            _first = _first.Next;
            return temp.Data;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        public NodeOne<T> Find(T key)
        {
            if(IsEmpty())
                throw new Exception("Список пустой");

            var node = _first;
            while (node != null)
            {
                if (node.Data.Equals(key))
                {
                    return node;
                }
                node = node.Next;
            }

            return null;
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
                    else
                        nodePrevios.Next = nodeCurrent.Next;
                    break;
                }
                nodePrevios = nodeCurrent;
                nodeCurrent = nodeCurrent.Next;
            }
        }

        public T Peek()
        {
            return _first.Data;
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
