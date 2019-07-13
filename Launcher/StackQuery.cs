using System;
using AlgoritmicsBookFW.StackQuery;

namespace AlgoritmicsBookFW.Launcher
{
    class StackQuery
    {
        public void Run(string[] args = null)
        {
            int maxSize = 10;
            WorkWithDeq(maxSize);

            QueryStruct<long> structer;

            structer = new QueryStruct<long>(maxSize);

            Fill(structer, maxSize);

            structer.Remove();
            structer.Remove();

            structer.Insert(25);
            structer.Insert(90);
            structer.Remove();
            structer.Remove();
            structer.Insert(5);
            structer.Insert(2);
            structer.Display();
            Remove(structer);



        }

        private void WorkWithDeq(int maxSize)
        {
            DequeryStruct<long> dequ = new DequeryStruct<long>(maxSize);
            dequ.InsertLeft(1);
            dequ.InsertRight(2);
            dequ.InsertLeft(3);
            dequ.InsertRight(4);
            dequ.InsertLeft(5);
            dequ.InsertRight(6);
            dequ.InsertLeft(7);
            dequ.InsertRight(8);


            dequ.RemoveRight();
            dequ.RemoveRight();
            dequ.RemoveRight();
            dequ.RemoveRight();
            dequ.RemoveRight();
            dequ.RemoveRight();
            dequ.RemoveRight();

        }

        private void Fill(BaseStruct<long> arr, int maxSize)
        {
            for (int i = 0; i < maxSize; i++)
            {
                arr.Insert(maxSize * 10 * i);
            }
        }

        private void Remove(BaseStruct<long> arr)
        {
            while(!arr.IsEmpty())
            {
                Console.WriteLine(arr.Remove());
            }
        }

    }
}
