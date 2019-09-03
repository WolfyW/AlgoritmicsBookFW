using System;
using AlgoritmicsBookFW.Interface;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    public abstract class TreeAbstract<T> : ITree<T> where T : IComparable<T>
    {
        protected INode<T> RootNode;

        public abstract bool Find(T item);
        public abstract void Insert(T item);
        public abstract bool Remove(T item);

        public void Display()
        {
            WriteInfo(RootNode);
        }

        private void WriteInfo(INode<T> current)
        {
            if (current != null)
            {
                WriteInfo(current.Left);
                Console.WriteLine(current.Data.ToString());
                WriteInfo(current.Right);
            }
        }
    }
}