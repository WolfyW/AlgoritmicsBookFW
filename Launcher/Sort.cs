using System;

using AlgoritmicsBookFW.Interface;
using AlgoritmicsBookFW.SortingApp;

namespace AlgoritmicsBookFW.Launcher
{
    class Sort
    {
        public void Run(string[] args = null)
        {
            int maxSize = 100000;
            ExecuteSortWithDisplay(new BubbleArray<long>(25), FillRandomArray, 25, "Bubble sort Random");
            ExecuteSortWithDisplay(new SelectedArray<long>(25), FillRandomArray, 25, "Selected sort Random");
            ExecuteSortWithDisplay(new InsertSort<long>(25), FillRandomArray, 25, "Insert sort Random");
            ExecuteSortWithDisplay(new MergeSort<long>(25), FillRandomArray, 25, "Merge sort Random");
            ExecuteSortWithDisplay(new ShellSort<long>(25), FillRandomArray, 25, "Shell sort Random");
            ExecuteSortWithDisplay(new QuickSort(25), FillRandomArray, 25, "Quick sort Random");

            ExecuteSort(FillRandomArray, maxSize, "Random");
            ExecuteSort(FillArr, maxSize, "Ended");
            ExecuteSort(FillSortedArr, maxSize, "Sorted");

            Console.WriteLine();
            Console.WriteLine("End Program");

            MergeSort<long> rec = new MergeSort<long>(2);
            long[] tempA = new long[] { 9, 4, 2, 7, 6, 1, 3, 5, 8, 10 };
            var t = rec.SortOther();
            
            Console.Read();
        }

        /// <summary>
        /// Основное действие
        /// </summary>
        /// <param name="Fill">Метод заполнения массивов</param>
        /// <param name="maxSize">максимальная величина массива</param>
        /// <param name="message">сообщение</param>
        private void ExecuteSort(Action< IArray<long> , int > Fill, int maxSize, string message)
        {
            Console.WriteLine($"{message} method");
            IArray<long> arr1;
            //arr1 = new BubbleArray<long>(maxSize);
            //Fill(arr1, maxSize);
            //SortArr(arr1, "Buble sort " + message);

            //arr1 = new SelectedArray<long>(maxSize);
            //Fill(arr1, maxSize);
            //SortArr(arr1, "Selected sort " + message);

            //arr1 = new InsertSort<long>(maxSize);
            //Fill(arr1, maxSize);
            //SortArr(arr1, "Insert sort " + message);

            arr1 = new MergeSort<long>(maxSize);
            Fill(arr1, maxSize);
            SortArr(arr1, "Merge sort " + message);

            arr1 = new ShellSort<long>(maxSize);
            Fill(arr1, maxSize);
            SortArr(arr1, "Shell sort " + message);

            arr1 = new QuickSort(maxSize);
            Fill(arr1, maxSize);
            SortArr(arr1, "Quick sort " + message);
            Console.WriteLine();
        }

        private void ExecuteSortWithDisplay(IArray<long> arr, Action<IArray<long>, int> Fill, int maxSize, string message)
        {
            if (maxSize > 50)
                throw new ArgumentException();

            Fill(arr, maxSize);
            arr.Display();
            SortArr(arr, message);
            arr.Display();
            //var t = arr as InsertSort<long>;
            //if (t != null)
            //{
            //    Console.WriteLine(t.Median());
            //    t.Nodups();
            //    t.Display();
            //}
            
            Console.WriteLine("\n############ END ############\n");
        }

        /// <summary>
        /// Заполняет массив случайными числами
        /// </summary>
        /// <param name="arr">какой массив заполнить</param>
        /// <param name="maxSize">сколько чисел</param>
        private void FillRandomArray(IBaseStruct<long> arr, int maxSize)
        {
            Random rand = new Random();
            for (int i = 0; i < maxSize; i++)
            {
                arr.Insert(rand.Next(0, maxSize));
            }
        }

        private void FillStaticMembers(IBaseStruct<long> arr, int maxSize)
        {
            if (maxSize != 20)
                throw new Exception();

            arr.Insert(2);
            arr.Insert(2 );
            arr.Insert(2 );
            arr.Insert(3 );
            arr.Insert(3);
            arr.Insert(3);
            arr.Insert(4);
            arr.Insert(4);
            arr.Insert(4);
            arr.Insert(5);
            arr.Insert(5);
            arr.Insert(5);
            arr.Insert(6);
            //arr.Insert(10);
            //arr.Insert(10);
            //arr.Insert(10);
            //arr.Insert(11);
            //arr.Insert(12);
            //arr.Insert(13);
            //arr.Insert(13);
            //arr.Insert(16);
            //arr.Insert(16);
            //arr.Insert(18);
            //arr.Insert(19);
            //arr.Insert(19);
        }

        /// <summary>
        /// Заполняет массив отсортированными числами в обратном порядке
        /// </summary>
        /// <param name="arr">какой массив заполнить</param>
        /// <param name="maxSize">сколько чисел</param>
        private void FillArr(IBaseStruct<long> arr, int maxSize)
        {
            int number = maxSize - 1;
            for (int i = 0; i < maxSize; i++)
            {
                arr.Insert(--number);
            }
        }

        /// <summary>
        /// Заполянет массив отсортированными числами
        /// </summary>
        /// <param name="arr">какой массив заполнить</param>
        /// <param name="maxSize">сколько чисел</param>
        private void FillSortedArr(IBaseStruct<long> arr, int maxSize)
        {
            for (int i = 0; i < maxSize; i++)
            {
                arr.Insert(i);
            }
        }

        /// <summary>
        /// Сортирует массив и выводи количество времени затраченное на сортировку в секундах
        /// </summary>
        /// <param name="arr">какой массив сортировать</param>
        /// <param name="message">сообщение которое выведется на экран вместе со временем</param>
        private void SortArr(ISortArray<long> arr, string message)
        {
            DateTime now;
            DateTime end;

            now = DateTime.Now;
            arr.Sort();
            end = DateTime.Now;

            TimeSpan span = end - now;
            Console.WriteLine(message + ": " + span.TotalSeconds);
        }
    }
}
