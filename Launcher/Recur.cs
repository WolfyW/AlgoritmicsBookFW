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
            Factorial fac = new Factorial(40);

            Console.WriteLine("Tringle Numbers");
            MathRrcuration(num);
            Console.WriteLine("Factorials");

            MathRrcuration(fac);

        }

        public void MathRrcuration(IRecurectionMath rec)
        {
            Console.WriteLine(rec.ResultRec);
            Console.WriteLine(rec.ResultNotRec);
            Console.WriteLine(rec.MathWithRec(20));
            Console.WriteLine(rec.MathWithoutRec(20));
        }

    }
}
