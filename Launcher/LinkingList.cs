using System;
using AlgoritmicsBookFW.LinkedList;

namespace AlgoritmicsBookFW.Launcher
{
    class LinkingList
    {
        public void Run()
        {
            LinkList<long> list = new LinkList<long>();
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

            list.DeleteKey(15l);

            DeleteFromList(list);
        }

        private void FillList(LinkList<long> list)
        {
            Random rnd = new Random();
            for (int i =0; i < 10; i++)
            {
                long item = rnd.Next(100, 999);
                list.AddFirst(item);
            }
        }


        private void DeleteFromList(LinkList<long> list)
        {
            while (!list.IsEmpty())
            {
                Console.WriteLine("delete: " + list.DeleteFirst());
            }
        }
        
        
    }
}
