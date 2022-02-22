using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество прямоугольников в гистограмме: ");
            int countOfRectangles = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное значение высоты прямоугольника в гистограмме: ");
            int rectangleMaxHeight = int.Parse(Console.ReadLine());

            int[] hystogramHeightArray = GenerateHeightArray(countOfRectangles, rectangleMaxHeight);
            int maxHystogramRectangleArea = MaximumRectangleArea(hystogramHeightArray);

            Console.WriteLine($"Результат вычисления для гистограммы с {countOfRectangles} прямоугольниками и максимальной высотой шкалы, равной {rectangleMaxHeight}: {maxHystogramRectangleArea}");
        }

        static int[] GenerateHeightArray(int count, int maxValue)
        {
            Random random = new Random();
            int[] heightArray = new int[count];
            for(int i = 0; i < heightArray.Length; i++)
            {
                heightArray[i] = random.Next(1, maxValue + 1);
            }
            return heightArray;
        }

        //TODO
        static int MaximumRectangleArea(int[] array)
        {
            Stack<int> stack;
            return 0;
        }
    }
}
