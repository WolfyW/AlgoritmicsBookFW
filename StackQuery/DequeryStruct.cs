using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class DequeryStruct<T>
    {
        private int _nElements;
        private readonly T[] _a;

        private int _left;
        private int _right;

        public DequeryStruct(int maxSize)
        {
            _a = new T[maxSize];
            _left = -1;
            _right = -1;
        }

        public void InsertLeft(T item)
        {
            if (_nElements == _a.Length)
                throw new Exception("Заполнено");

            if (_left == -1 || IsEmpty())
            {
                _left = 0;
                _right = 0;
            }
            else if (!IsEmpty() && _left == 0)
                _left = _a.Length - 1;
            else
                _left--;

            _nElements++;
            _a[_left] = item;
        }

        public void InsertRight(T item)
        {
            if (_nElements == _a.Length)
                throw new Exception("Заполнено");

            if (_right == _a.Length -1)
                _right = -1;

            if (IsEmpty())
            {
                _left = 0;
                _right = -1;
            }

            _nElements++;
            _a[++_right] = item;
        }

        public T RemoveLeft()
        {
            if (IsEmpty())
                throw new Exception("Пусто");

            T temp = _a[_left];
            _a[_left] = default(T);

            if (_left == _a.Length - 1)
                _left = 0;
            else
                _left++;

            _nElements--;
            return temp;

        }

        public T RemoveRight()
        {
            if (IsEmpty())
                throw new Exception("Пусто");

            T temp = _a[_right];
            _a[_right] = default(T);

            if (_right == 0)
                _right = _a.Length - 1;
            else
                _right--;

            _nElements--;
            return temp;
        }

        public bool IsEmpty()
        {
            return _nElements == 0;
        }

        public bool IsFull()
        {
            return _nElements == _a.Length;
        }
    }
}
