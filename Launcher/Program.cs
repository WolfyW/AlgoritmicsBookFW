﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            LinkingList list = new LinkingList();
            list.Run();

            Console.Read();
        }
    }
}
