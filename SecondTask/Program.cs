using System;

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

            int[] test = { 10, 5, 10, 8, 6, 4, 8, 5, 4, 6 };

            //int[] hystogramHeightArray = HystogramMathHelper.HeightArrayGenerator(countOfRectangles, rectangleMaxHeight);
            int maxHystogramRectangleArea = HystogramMathHelper.MaximumRectangleArea(test);

            Console.WriteLine("Сгенерированы следующие узлы гистограммы:");
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i].ToString());
            }

            Console.WriteLine($"Площадь самого большого прямоугольника на этой гистограмме: {maxHystogramRectangleArea}");
            Console.ReadKey();
        }
    }
}
