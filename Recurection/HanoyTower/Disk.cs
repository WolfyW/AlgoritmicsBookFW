using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.Recurection.HanoyTower
{
    class Disk
    {
        public int Number { get; private set; }
        public Disk(int num)
        {
            Number = num;
        }

        public override string ToString()
        {
            return "Disk " + Number;
        }
    }
}
