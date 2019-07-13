using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicsBookFW.Interface
{
    public interface ISQ<T>
    {
        /// <summary>
        /// Посмотреть последний элемент
        /// </summary>
        /// <returns></returns>
        T Peek();

        /// <summary>
        /// Удалить последний элемент
        /// </summary>
        /// <returns></returns>
        T Remove();

        /// <summary>
        /// Вставить элемент
        /// </summary>
        /// <param name="item"></param>
        void Insert(T item);
    }
}
