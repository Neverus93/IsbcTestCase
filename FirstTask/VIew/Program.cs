using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>(10);

            for(int i = 1; i <= 10; i++)
            {
                numbers.Enqueue(i);
            }
        }
    }
}
