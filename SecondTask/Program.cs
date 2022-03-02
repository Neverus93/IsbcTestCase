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

            HystogramNode[] test = new HystogramNode[5];
            test[0] = new HystogramNode(1, 10);
            test[1] = new HystogramNode(2, 5);
            test[2] = new HystogramNode(3, 0);
            test[3] = new HystogramNode(4, 8);
            test[4] = new HystogramNode(5, 6);

            //int[] hystogramHeightArray = HystogramMathHelper.HeightArrayGenerator(countOfRectangles, rectangleMaxHeight);
            int maxHystogramRectangleArea = HystogramNode.MaximumRectangleArea(test);

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
