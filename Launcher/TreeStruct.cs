using AlgoritmicsBookFW.TreeStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.Launcher
{
    class TreesRun
    {
        public void Run()
        {
            Tree<long> tree = new Tree<long>();
            Random rnd = new Random();
            List<long> items = new List<long>();
            items.Add(15);
            items.Add(10);
            items.Add(35);
            items.Add(5);
            items.Add(13);
            items.Add(30);
            items.Add(45);
            items.Add(3);
            items.Add(7);
            items.Add(12);
            items.Add(14);
            items.Add(25);
            items.Add(37);
            items.Add(33);
            items.Add(40);
            items.Add(50);

            foreach (var item in items)
            {
                tree.Insert(item);
            }

            tree.Display();

            Console.WriteLine("Max: " + tree.Max());
            Console.WriteLine("Min: " + tree.Min());

            Console.WriteLine("Find: " + tree.Find(25));

            tree.Remove(14);
            tree.Remove(3);
            tree.Remove(35);
            tree.Remove(15);



            tree.Display();
        }
    }
}
