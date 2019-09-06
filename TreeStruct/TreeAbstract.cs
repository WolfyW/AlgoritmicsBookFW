using System;
using AlgoritmicsBookFW.Interface;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    public abstract class TreeAbstract<TData, TNode> : ITree<TData> where TData : IComparable<TData>
                                                         where TNode : INode<TData, TNode>
    {
        protected TNode RootNode;

        public abstract bool Find(TData item);
        public abstract void Insert(TData item);
        public abstract bool Remove(TData item);

        public void Display()
        {
            WriteInfo(RootNode);
        }

        private void WriteInfo(TNode current)
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