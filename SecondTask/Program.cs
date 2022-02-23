using System;
using System.Collections.Generic;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите количество прямоугольников в гистограмме: ");
            //int countOfRectangles = int.Parse(Console.ReadLine());
            //Console.Write("Введите максимальное значение высоты прямоугольника в гистограмме: ");
            //int rectangleMaxHeight = int.Parse(Console.ReadLine());

            int countOfRectangles = 4;
            int rectangleMaxHeight = 4;


            HystogramNode[] hystogramHeightArray = HystogramNode.GenerateHeightArray(countOfRectangles, rectangleMaxHeight);
            int maxHystogramRectangleArea = HystogramNode.MaximumRectangleArea(hystogramHeightArray);

            Console.WriteLine($"Результат вычисления для гистограммы с {countOfRectangles} прямоугольниками и максимальной высотой шкалы, равной {rectangleMaxHeight}: {maxHystogramRectangleArea}");
        }
    }
}
