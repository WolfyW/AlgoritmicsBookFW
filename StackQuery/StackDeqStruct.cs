namespace AlgoritmicsBookFW.StackQuery
{
    public class StackDeqStruct<T>
    {
        private DequeryStruct<T> deq;

        public StackDeqStruct(int maxSize)
        {
            deq = new DequeryStruct<T>(maxSize);
        }

        public void Push(T item)
        {
            deq.InsertRight(item);
        }

        public T Pop()
        {
            return deq.RemoveRight();
        }

        public T Peek()
        {
            T temp = deq.RemoveRight();
            deq.InsertRight(temp);
            return temp;
        }

        public bool IsEmpty()
        {
            return deq.IsEmpty();
        }
    }
}
