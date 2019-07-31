namespace AlgoritmicsBookFW.LinkedList
{
    public class IteratorTwoList<T> : IIterator<T>
    {
        private readonly LinkedListTwoWay<T> _list;
        private NodeTwo<T> _current;
        private NodeTwo<T> _priviois;

        public IteratorTwoList(LinkedListTwoWay<T> list)
        {
            _list = list;
            Reset();
        }

        public void Reset()
        {
            _current = _list.First;
        }

        public void AddBefore(T item)
        {
            NodeTwo<T> newNode = new NodeTwo<T>(item);
            _priviois.Next = newNode;
            newNode.Previus = _priviois;

            _current.Previus = newNode;
            newNode.Next = _current;
        }

        public void AddAfter(T item)
        {
            NodeTwo<T> newNode = new NodeTwo<T>(item);
            var temp = _current.Next;

            _current.Next = newNode;
            newNode.Previus = _current;

            newNode.Next = temp;
            temp.Previus = newNode;
        }

        public bool MoveNext()
        {
            _priviois = _current;
            _current = _current.Next;
            if (_current == null)
                return false;
            return true;
        }

        /// <internalonly/>
        public T GetCurrent()
        {
            return _current.Data;
        }

        public bool AtEnd()
        {
            return _current.Next == null;
        }
    }
}
