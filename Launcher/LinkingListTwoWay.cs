using System;
using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.Launcher
{
    class LinkingListTwoWay
    {
        public void Run()
        {
            LinkedListTwoWay<long> list = new LinkedListTwoWay<long>();
            Console.WriteLine("Fill list");
            FillList(list);
            var iter = list.GetIterator();
            int count = 1;
            while (true)
            {
                if (count % 10 == 0)
                    Console.WriteLine();
                var it = iter.GetCurrent();
                Console.Write(it + " ");
                bool res = iter.MoveNext();
                if (res == false)
                    break;
                count++;
            }
            iter.Reset();
            Console.WriteLine("End");
            iter.MoveNext();
            iter.MoveNext();
            iter.AddBefore(20l);
            iter.MoveNext();
            iter.MoveNext();
            iter.AddAfter(15l);

            list.RemoveKey(15l);

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            DeleteFromList(list);
        }

        private void FillList(LinkedListTwoWay<long> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                long item = rnd.Next(100, 999);
                list.AddFirst(item);
            }
        }

        private void DeleteFromList(LinkedListTwoWay<long> list)
        {
            while (!list.IsEmpty())
            {
                Console.WriteLine("delete: " + list.RemoveFirst());
            }
        }
    }
}
