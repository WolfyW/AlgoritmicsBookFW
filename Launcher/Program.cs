using System;
using AlgoritmicsBookFW.SortingApp;

namespace AlgoritmicsBookFW.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort sort = new Sort();
            //sort.Run();

            //StackQuery stack = new StackQuery();
            //stack.Run();

            //LinkingList list = new LinkingList();
            //list.Run();

            //LinkingListTwoWay listTwo = new LinkingListTwoWay();
            //listTwo.Run();

            //Recur re = new Recur();
            //re.Run();
            MergeSort<long> rec = new MergeSort<long>(2);
            long[] tempA = new long[] {9, 4, 2, 7, 6, 1, 3, 5, 8, 10};
            var t = rec.SortOther(tempA);

            Console.Read();
        }
    }
}
