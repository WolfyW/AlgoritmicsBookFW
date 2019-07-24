using System;
using AlgoritmicsBookFW.Iterator;

namespace AlgoritmicsBookFW.LinkedList
{
    public class LinkList<T>
    {
        public NodeOne<T> First { get; private set; }

        public LinkList()
        {
            First = null;
        }

        public void AddFirst(T item)
        {
            var node = new NodeOne<T>(item);
            node.Next = First;
            First = node;
        }

        public T DeleteFirst()
        {
            if (IsEmpty())
                throw new Exception("Пустой список");

            var temp = First;
            First = First.Next;
            return temp.Data;
        }

        public bool IsEmpty()
        {
            return First == null;
        }

        public NodeOne<T> Find(T key)
        {
            if(IsEmpty())
                throw new Exception("Список пустой");

            var node = First;
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

            var nodeCurrent = First;
            var nodePrevios = First;

            while (!IsEmpty())
            {
                if (nodeCurrent.Data.Equals(key))
                {
                    if (nodeCurrent == First)
                        First = First.Next;
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
            return First.Data;
        }

        public void Display()
        {
            var node = First;

            while (node != null)
            {
                Console.Write(node.ToString());
                node = node.Next;
            }
            Console.WriteLine();
        }

        public Iterator<T> GetIterator()
        {
            return new Iterator<T>(this);
        }
    }
}
