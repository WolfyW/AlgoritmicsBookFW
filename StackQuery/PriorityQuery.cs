using System;

namespace AlgoritmicsBookFW.StackQuery
{
    public class PriorityQuery<T> : BaseStruct<T>
    {

        public PriorityQuery(int maxSize) : base(maxSize)
        { }

        public override void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public override T Peek()
        {
            throw new NotImplementedException();
        }

        public override T Remove()
        {
            throw new NotImplementedException();
        }

        public bool Find(T item, out int index)
        {
            index = -1;


            return false;
        }
    }
}
