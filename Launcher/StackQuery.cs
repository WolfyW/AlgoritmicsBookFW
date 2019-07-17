using System;
using AlgoritmicsBookFW.StackQuery;

namespace AlgoritmicsBookFW.Launcher
{
    class StackQuery
    {
        public void Run(string[] args = null)
        {
            int maxSize = 10;
            WorkWithStackLinkList(maxSize);
            WorkWithLinkedQuery(maxSize);
            WorkWithQuery(maxSize);
            WorkWithDeq(maxSize);
            WorkWithStack(maxSize);
            WorkWithStackDeqStruct(maxSize);
            WorkWithPriorityQuery(maxSize);
            WorkWithPriorityQ(maxSize);
        }

        private void WorkWithLinkedQuery(int maxSize)
        {
            ShowName("QureyLink");
            QueryLinkList<long> link = new QueryLinkList<long>();

            for (int i = 0; i < maxSize; i++)
            {
                link.Insert(maxSize * 10 * i);
            }

            while (!link.IsEmpty())
            {
                Console.WriteLine(link.Remove());
            }
            ShowEndMessage();
        }

        private void WorkWithQuery(int maxSize)
        {
            ShowName("Qurey");

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
            ShowEndMessage();
        }

        private void WorkWithDeq(int maxSize)
        {
            ShowName("Dequi");
            DequeryStruct<long> dequ = new DequeryStruct<long>(maxSize);
            dequ.InsertLeft(1);
            dequ.InsertRight(2);
            dequ.InsertLeft(3);
            dequ.InsertRight(4);
            dequ.InsertLeft(5);
            dequ.InsertRight(6);
            dequ.InsertLeft(7);
            dequ.InsertRight(8);

            while (!dequ.IsEmpty())
            {
                Console.WriteLine(dequ.RemoveRight());
            }
            ShowEndMessage();
        }

        private void WorkWithStackLinkList(int maxSize)
        {
            ShowName("StackLink");
            StackLinkList<long> stack = new StackLinkList<long>();

            for (int i = 0; i < maxSize; i++)
            {
                stack.Insert(maxSize * 10 * i);
            }

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Remove());
            }
            ShowEndMessage();
        }

        private void WorkWithStack(int maxSize)
        {
            ShowName("Stack");
            StackStruct<long> stack = new StackStruct<long>(maxSize);

            Fill(stack, maxSize);
            try
            {
                stack.Insert(6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Remove(stack);

            try
            {
                stack.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            ShowEndMessage();
        }

        private void WorkWithStackDeqStruct(int maxSize)
        {
            ShowName("StackDeqStruct");
            StackDeqStruct<long> stack = new StackDeqStruct<long>(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                stack.Push(maxSize * 10 * i);
            }
            try
            {
                stack.Push(6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            try
            {
                stack.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ShowEndMessage();

        }

        private void WorkWithPriorityQuery(int maxSize)
        {
            ShowName("PriorityQuery");
            PriorityQuery<long> prioQ = new PriorityQuery<long>(maxSize);

            Random rnd = new Random();
            for (int i = 0; i < maxSize; i++)
            {
                prioQ.Insert(rnd.Next(0, 2000));
            }

            try
            {
                prioQ.Insert(6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Remove(prioQ);

            try
            {
                prioQ.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ShowEndMessage();
        }

        private void WorkWithPriorityQ(int maxSize)
        {
            ShowName("PriorityQ");
            PriorityQ<long> prioQ = new PriorityQ<long>(maxSize);
            Random rnd = new Random();
            for (int i = 0; i < maxSize; i++)
            {
                prioQ.Insert(rnd.Next(0, 2000));
            }
            try
            {
                prioQ.Insert(6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Remove(prioQ);

            try
            {
                prioQ.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ShowEndMessage();
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

        private void ShowName(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#-------##--------#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Work with " + message);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#-------##--------#");
            Console.ResetColor();
        }

        private void ShowEndMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("#-------end-------#");
            Console.WriteLine();
            Console.ResetColor();

        }
    }
}
