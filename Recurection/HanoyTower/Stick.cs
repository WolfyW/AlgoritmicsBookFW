using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.Recurection.HanoyTower
{
    class Stick
    {
        public Disk[] Disks { get; private set; }
        public char Name { get; private set; }
        public bool IsEmpty
        {
            get
            {
                return currentIndexDisk < 0;
            }
        }

        private int currentIndexDisk;

        public Stick(char name, Disk[] disks)
        {
            Disks = disks;
            Name = name;
            currentIndexDisk = Disks.Length - 1;
        }

        public Stick(int size, char name)
        {
            Disks = new Disk[size];
            Name = name;
            currentIndexDisk = -1;
        }

        public void PlaceDisk(Disk disk)
        {
            if (currentIndexDisk > 0)
                if (disk.Number > Disks[currentIndexDisk].Number)
                    throw new Exception("Wrong Number");

            Disks[++currentIndexDisk] = disk;
        }

        public Disk TakeDisk()
        {
            var disk = Disks[currentIndexDisk];
            Disks[currentIndexDisk--] = null;
            return disk;
        }

        public string Display()
        {
            if (IsEmpty)
                return this.ToString() + " is Empty";

            string info = string.Empty;
            for (int i = currentIndexDisk; i >= 0; i--)
                info += Disks[i].ToString() + "\n";

            return info;
        }

        public override string ToString()
        {
            return "Stick " + Name;
        }
    }
}
