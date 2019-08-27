using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmicsBookFW.Recurection;
using AlgoritmicsBookFW.Recurection.HanoyTower;


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

            //Console.WriteLine("Anagramm");
            //Anagramm("cat");
            //Anagramm("Мария");

            Console.WriteLine("Recuraction Search");
            RecurectionBinarySearch search = new RecurectionBinarySearch();
            search.MathWithRec(750);
            search.MathWithoutRec(750);
            Console.WriteLine(search.ResultNotRec);
            Console.WriteLine(search.ResultRec);

            Console.WriteLine(search.OtherSearch(950));

            HanoyTowerRecur tower = new HanoyTowerRecur(4, false);
        }

        public void Anagramm(string word)
        {
            AnagrammRecurection anagramm = new AnagrammRecurection(word);
            foreach (var item in anagramm.AnagrammWords)
            {
                Console.WriteLine(item);
            }
        }

        public void MathRrcuration(IRecurectionMath<long, int> rec)
        {
            Console.WriteLine(rec.ResultRec);
            Console.WriteLine(rec.ResultNotRec);
            Console.WriteLine(rec.MathWithRec(20));
            Console.WriteLine(rec.MathWithoutRec(20));
        }
    }
}
