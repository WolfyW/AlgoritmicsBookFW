using System;
using AlgoritmicsBookFW.Interface;

namespace AlgoritmicsBookFW.TreeStruct
{
    public class Tree<T> : ITree<T> where T : IComparable<T>
    {
        private NodeTree<T> _rootNode;

        public void Insert(T item)
        {
            var newNode = new NodeTree<T>(item);

            if (_rootNode == null)
                _rootNode = newNode;
            else
            {
                NodeTree<T> privious = _rootNode;
                NodeTree<T> current = _rootNode;
                while (true)
                {
                    privious = current;
                    if (item.CompareTo(current.Data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            privious.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            privious.Right = newNode;
                            return;
                        }
                    }
                }

            }
        }

        public bool Remove(T item)
        {
            bool isLeftChild;
            NodeTree<T> parent;

            var current = FindItem(item, out parent, out isLeftChild);
            if (current == null)
                return false;

            if (current.Left == null && current.Right == null)
            {
                if (current == _rootNode)
                    _rootNode = null;
                else if (isLeftChild)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (current.Right == null)
            {
                if (current == _rootNode)
                    _rootNode = current.Left;
                else if (isLeftChild)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Left;
                }
            }
            else if (current.Left == null)
            {
                if (current == _rootNode)
                    _rootNode = current.Right;
                else if (isLeftChild)
                {
                    parent.Left = current.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {
                NodeTree<T> succesor = GetSuccessor(current);
                if (current == _rootNode)
                    _rootNode = succesor;
                else if (isLeftChild)
                    parent.Left = succesor;
                else
                    parent.Right = succesor;

                succesor.Left = current.Left;
            }

            return true;
        }

        private NodeTree<T> GetSuccessor(NodeTree<T> delNode)
        {
            NodeTree<T> sucParent = delNode;
            NodeTree<T> suc = delNode;
            NodeTree<T> currnet = delNode.Right;

            while (currnet != null)
            {
                sucParent = suc;
                suc = currnet;
                currnet = currnet.Left;
            }

            if (suc != delNode.Right)
            {
                sucParent.Left = suc.Right;
                suc.Right = delNode.Left;
            }

            return suc;
        }

        public bool Find(T item)
        {
            NodeTree<T> current = _rootNode;
            while (current.Data.CompareTo(item) != 0)
            {
                if (current.Data.CompareTo(item) < 0)
                    current = current.Left;
                else
                    current = current.Right;

                if (current == null)
                    return false;
            }
            return true;
        }

        private NodeTree<T> FindItem(T item, out NodeTree<T> parent, out bool isLeftChild)
        {
            NodeTree<T> current = _rootNode;
            parent = _rootNode;
            isLeftChild = false;

            while (current.Data.CompareTo(item) != 0)
            {
                if (current.Data.CompareTo(item) < 0)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }

                if (current == null)
                    return null;
            }
            return current;
        }

        private NodeTree<T> FindItem(T item, out NodeTree<T> parent)
        {
            bool isLeft = true;
            var temp = FindItem(item, out parent, out isLeft);
            return temp;
        }

        public T Max()
        {
            var current = _rootNode;
            var previous = current;
            while (current != null)
            {
                previous = current;
                current = current.Right;
            }

            return previous.Data;
        }

        public T Min()
        {
            var current = _rootNode;
            var previous = current;
            while (current != null)
            {
                previous = current;
                current = current.Left;
            }

            return previous.Data;
        }

        public void Display()
        {
            WriteInfo(_rootNode);
        }

        private void WriteInfo(NodeTree<T> current)
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
