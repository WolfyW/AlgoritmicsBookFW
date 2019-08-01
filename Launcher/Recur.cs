using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmicsBookFW.Recurection;

namespace AlgoritmicsBookFW.Launcher
{
    class Recur
    {
        public void Run()
        {
            TriangleNumbers num = new TriangleNumbers(40);
            Console.WriteLine(num.NumberRec);
            Console.WriteLine(num.NumberNotRec);
            Console.WriteLine(num.TriangleRecur(20));
            Console.WriteLine(num.TriangleNotRecur(20));
        }
    }
}
