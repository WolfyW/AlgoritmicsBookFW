using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmicsBookFW.StackQuery;

namespace AlgoritmicsBookFW.Recurection
{
    public class PowNumbers
    {
        public double Number { get; private set; }
        public int Pow { get; private set; }

        public PowNumbers(int num, int pow)
        {
            Number = num;
            Pow = pow;
        }
    }

    public class RecursivePow : IRecurectionMath<double, PowNumbers>
    {
        public double ResultRec { get; }
        public double ResultNotRec { get; }

        public RecursivePow(PowNumbers num)
        {
            ResultRec = MathWithRec(num);
            ResultNotRec = MathWithoutRec(num);
        }

        public double MathWithRec(PowNumbers number)
        {
            double num = number.Number;
            int pow = number.Pow;
            return Power(num, pow);
        }

        private double Power(double num, int pow)
        {
            if (pow == 1)
                return num;
            var res = Power(num * num, pow / 2);
            if (pow % 2 != 0)
                res *= num;
            return res;
        }

        public double MathWithoutRec(PowNumbers number)
        {
            int exponent = number.Pow;
            double @base = number.Number;

            double power = 1.0;
            if (exponent < 0)                       // Возведение в отрицательную степень
            {
                exponent = -exponent;               // эквивалентно возведению в такую же положительную степень
                @base = 1.0 / @base;                // обратного основанию числа (1 / основание).
            }
            while (exponent > 0)                    // Пока текущее значение показателя степени не равно 0:
            {
                if ((exponent & 1) != 0)            // Если оно нечётно,
                    power *= @base;                 // результат умножается на текущее значение основания.
                exponent >>= 1;                     // Показатель степени делится на 2.
                @base *= @base;                     // Основание возводится в квадрат.
            }
            return power;
        }
    }
}
