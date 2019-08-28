using System;
using AlgoritmicsBookFW.Recurection;

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

            RecursivePow pow = new RecursivePow(new PowNumbers(2, 21));
            var t = pow.ResultRec;
            var t1 = pow.ResultNotRec;



            Console.Read();
        }
    }
}
