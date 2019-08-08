using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.Recurection.HanoyTower
{
    public class HanoyTowerRecur
    {
        private Stick A;
        private Stick B;
        private Stick C;

        bool writeActions = true;
        public HanoyTowerRecur(int size, bool writeActions)
        {
            this.writeActions = writeActions;
            StartReplacement(size);

            if (this.writeActions == false)
            {
                Console.WriteLine(A);
                Console.WriteLine(A.Display());

                Console.WriteLine(B);
                Console.WriteLine(B.Display());

                Console.WriteLine(C);
                Console.WriteLine(C.Display());
            }
        }
        public HanoyTowerRecur(int size)
        {
            char stickA = 'A';
            char stickB = 'B';
            char stickC = 'C';
            DoTowers(size, stickA, stickB, stickC);
        }

        private void StartReplacement(int size)
        {
            Disk[] disks = new Disk[size];
            int num = size;
            for (int i = 0; i < size; i++)
            {
                disks[i] = new Disk(num);
                num--;
            }

            A = new Stick('A', disks);
            B = new Stick(size, 'B');
            C = new Stick(size, 'C');

            DoTowers(size, A, B, C);
        }

        private void DoTowers(int topN, Stick from, Stick inner, Stick to)
        {
            if (topN == 1)
            {
                if (writeActions)
                    Console.WriteLine("Disk 1 from " + from + " to " + to);
                var disk = from.TakeDisk();
                to.PlaceDisk(disk);
            }
            else
            {
                DoTowers(topN - 1, from, to, inner);
                if (writeActions)
                    Console.WriteLine("Disk " + topN + " from " + from + " to " + to);
                var disk = from.TakeDisk();
                to.PlaceDisk(disk);
                DoTowers(topN - 1, inner, from, to);
            }
        }

        private void DoTowers(int topN, char from, char inner, char to)
        {
            if (topN == 1)
                Console.WriteLine("Disk 1 from " + from + " to " + to);
            else
            {
                DoTowers(topN - 1, from, to, inner);
                Console.WriteLine("Disk " + topN + " from " + from + " to " + to);
                DoTowers(topN - 1, inner, from, to);
            }
        }
    }
}
