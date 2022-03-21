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

            //HystogramNode[] test = new HystogramNode[8];
            //test[0] = new HystogramNode(1, 0);
            //test[1] = new HystogramNode(2, 3);
            //test[2] = new HystogramNode(3, 1);
            //test[3] = new HystogramNode(4, 6);
            //test[4] = new HystogramNode(5, 2);
            //test[5] = new HystogramNode(6, 7);
            //test[6] = new HystogramNode(7, 8);
            //test[7] = new HystogramNode(8, 5);
            //test[8] = new HystogramNode(9, 4);
            //test[9] = new HystogramNode(10, 6);
            //test[6] = new HystogramNode(7, 5);
            //test[7] = new HystogramNode(8, 0);

            HystogramNode[] hystogramHeightArray = HystogramNode.GenerateHeightArray(countOfRectangles, rectangleMaxHeight);
            int maxHystogramRectangleArea = HystogramNode.MaximumRectangleArea(hystogramHeightArray);
            //int maxHystogramRectangleArea = HystogramNode.MaximumRectangleArea(test);

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
