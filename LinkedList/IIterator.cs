using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.LinkedList
{
    public interface IIterator<T>
    {
        bool MoveNext();
        T GetCurrent();
        bool AtEnd();
        void AddAfter(T item);
        void AddBefore(T item);
        void Reset();
    }
}
