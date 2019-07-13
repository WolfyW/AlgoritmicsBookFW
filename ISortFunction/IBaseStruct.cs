using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicsBookFW.Interface
{
    public interface IBaseStruct<T>
    {
        bool Remove(T item);

        void Insert(T item);
    }
}
