using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.Recurection
{
    public class PowNumbers
    {
        public int Number { get; private set; }
        public int Pow { get; private set; }

        public PowNumbers(int num, int pow)
        {
            Number = num;
            Pow = pow;
        }
    }

    public class RecursivePow : IRecurectionMath<long, PowNumbers>
    {
        public long ResultRec { get; }
        public long ResultNotRec { get; }

        public RecursivePow(PowNumbers num)
        {
            ResultRec = MathWithRec(num);
           // ResultNotRec = MathWithoutRec(num);
        }

        public long MathWithRec(PowNumbers number)
        {
            long num = number.Number;
            int pow = number.Pow;
            return Power(num, pow);
        }

        private long Power(long num, int pow)
        {
            if (pow == 1)
                return num;
            var res = Power(num * num, pow / 2);
            if (pow % 2 != 0)
                res *= num;
            return res;
        }

        public long MathWithoutRec(PowNumbers number)
        {
            throw new NotImplementedException();
        }
    }
}
