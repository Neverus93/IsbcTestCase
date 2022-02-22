using System;
using System.Collections.Concurrent;
using System.Threading;

namespace FirstTask.Model
{
    class Numbers
    {
        private static Semaphore semaphore = new Semaphore(1, 1);
        private Thread numberThread;
        private int count = 5;

        public ConcurrentQueue<int> NumbersQueue { get; set; }

        public Numbers(int countOfThreads, ConcurrentQueue<int> numbersQueue)
        {
            NumbersQueue = numbersQueue;
            numberThread = new Thread(() => OutputNumber(numbersQueue));
            numberThread.Name = $"Поток {countOfThreads}";
            numberThread.Start();
        }

        public ConcurrentQueue<int> OutputNumber(ConcurrentQueue<int> numbersQueue)
        {
            while (count > 0)
            {
                semaphore.WaitOne();
                int number;
                if (numbersQueue.TryDequeue(out number))
                {
                    Console.WriteLine($"{numberThread.Name}: {number} ");
                }
                Thread.Sleep(1000);
                semaphore.Release();
                count--;
            }
            return numbersQueue;
        }
    }
}
