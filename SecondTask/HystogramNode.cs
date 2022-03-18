using System;
using System.Collections.Generic;

namespace SecondTask
{
    public class HystogramNode
    {
        public int NodeHeight { get; set; }
        public int NodeIndex { get; set; }
        public HystogramNode(int width, int height)
        {
            NodeHeight = height;
            NodeIndex = width;
        }
        public static HystogramNode[] GenerateHeightArray(int count, int maxValue)
        {
            Random random = new Random();
            List<int> heightValues = new List<int>();

            foreach(var e in heightValues)
            {
                heightValues.Add(random.Next(1, maxValue + 1));
            }
            heightValues.Add(0);//Дополнительный элемент для алгоритма подсчёта

            int[] heightValuesArray = heightValues.ToArray(); //Массив полученных высот прямоугольников гистограммы

            HystogramNode[] heightArray = new HystogramNode[count + 1];

            for (int i = 0; i < heightArray.Length; i++)
            {
                heightArray[i] = new HystogramNode(i + 1, heightValuesArray[i]);
            }
            return heightArray;
        }

        public static int MaximumRectangleArea(HystogramNode[] array)
        {
            int maxRectangleArea = 0; //объявляем переменную, в которую будет записан результат вычисления площади максимального прямоугольника, вписанного в стек
            int countOfHystogramElements = array.Length; //количество прямоугольников гистограммы
            Stack<HystogramNode> stack = new Stack<HystogramNode>(); //заводим стек из прямоугольников гистограммы
            HystogramNode minusOneElement = new HystogramNode(0, -1); //добавляем элемент с высотой -1, который никогда не будет вытолкнут из стека
            stack.Push(minusOneElement); //добавляем элемент высотой -1 в стек
          
            for(int i = 0; i < countOfHystogramElements; i++)
            {
                if (array[i].NodeHeight > stack.Peek().NodeHeight)
                {
                    stack.Push(array[i]);
                }
                else
                {
                    for(int j = 0; j > stack.Count; j++) //TODO Не заходит в цикл
                    {
                        int result = stack.Pop().NodeHeight * (j - i + 1);
                        if (result > maxRectangleArea)
                        {
                            maxRectangleArea = result;
                        }
                    }
                    stack.Push(array[i]);
                }
            }
            return maxRectangleArea;
        }

        public override string ToString()
        {
            return $"({NodeIndex},{NodeHeight})";
        }
    }
}
