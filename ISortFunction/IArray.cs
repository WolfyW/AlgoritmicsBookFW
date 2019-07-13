using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicsBookFW.Interface
{
    public interface IArray<T> : IBaseStruct<T>, ISortArray<T>
    {
        bool Find(T item);

        int Count();

        void Display();
    }
}
