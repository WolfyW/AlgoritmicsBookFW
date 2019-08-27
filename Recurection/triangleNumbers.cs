using AlgoritmicsBookFW.StackQuery;

namespace AlgoritmicsBookFW.Recurection
{
    public class TriangleNumbers : IRecurectionMath<long, int>
    {
        public long ResultRec { get; private set; }
        public long ResultNotRec { get; private set; }

        public TriangleNumbers(int number)
        {
            ResultRec = MathWithRec(number);
            ResultNotRec = MathWithoutRec(number);
        }

        public long MathWithRec(int number)
        {
            if (number == 1)
                return 1;
            else
                return number + MathWithRec(number - 1);
        }

        public long MathWithoutRec(int number)
        {
            long total = 0;
            while (number > 0)
            {
                total += number;
                number--;
            }

            return total;
        }

        public long MathWithStack(int number)
        {
            StackStruct<long> stack = new StackStruct<long>(500);
            long answer = 0;
            while (number > 0)
                stack.Insert(number--);
            while (!stack.IsEmpty())
                answer += stack.Remove();

            return answer;
        }
    }
}
