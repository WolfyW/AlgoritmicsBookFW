using System;
using AlgoritmicsBookFW.Recurection;
using AlgoritmicsBookFW.SortingApp;
using AlgoritmicsBookFW.TreeStruct;

namespace AlgoritmicsBookFW.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<long> tree = new Tree<long>();
            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                tree.Insert(rnd.Next(0,100));
            }
            tree.Display();

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

            //RecursivePow pow = new RecursivePow(new PowNumbers(2, 21));
            //var t = pow.ResultRec;
            //var t1 = pow.ResultNotRec;

            //int[] a = new[] {11, 8, 7, 6, 5};
            //BackpackPickUp p = new BackpackPickUp();
            //p.Pick(a, 20);

            Console.Read();
        }
    }
}
