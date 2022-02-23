using System;

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

            HystogramNode[] hystogramHeightArray = HystogramNode.GenerateHeightArray(countOfRectangles, rectangleMaxHeight);
            int maxHystogramRectangleArea = HystogramNode.MaximumRectangleArea(hystogramHeightArray);

            Console.WriteLine("Сгенерированы следующие узлы гистограммы:");
            for (int i = 0; i < hystogramHeightArray.Length; i++)
            {
                Console.WriteLine(hystogramHeightArray[i].ToString());
            }

            Console.WriteLine($"Площадь самого большого прямоугольника на этой гистограмме: {maxHystogramRectangleArea}");
            Console.ReadKey();
        }
    }
}
