using System.Collections.Concurrent;
using System.Collections.Generic;
using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numberList = new List<int>();
            ConcurrentQueue<int> numbersQueue = new ConcurrentQueue<int>(numberList);
            for (int i = 1; i <= 10; i++)
            {
                numbersQueue.Enqueue(i);
            }

            for (int i = 1; i < 3; i++)
            {
                Numbers numbers = new Numbers(i, numbersQueue);
            }
            Console.ReadKey();
        }
    }
}
