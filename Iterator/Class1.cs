using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.Iterator
{
    public interface IIterator
    {

    }

    public class Iterator<T>
    {
        private LinkList<T> node;
        private NodeOne<T> current;
        private NodeOne<T> priviois;

        public void Reset()
        {

        }

        public void MoveNext()
        {

        }

        /// <internalonly/>
        public T GetCurrent()
        {
            return current.Data;
        }


    }
}
