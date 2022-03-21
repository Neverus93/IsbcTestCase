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

            heightValues.Add(0); // Элемент необходим для обратной проверки блоков массива
            for (int i = 0; i < count; i++)
            {
                heightValues.Add(random.Next(1, maxValue + 1));
            }
            heightValues.Add(0); // Элемент необходим, чтобы в самом конце вытолкнуть все необходимые элементы из стека

            int[] heightValuesArray = heightValues.ToArray(); //Массив полученных высот прямоугольников гистограммы

            HystogramNode[] heightArray = new HystogramNode[count + 2];

            for (int i = 0; i < heightArray.Length; i++)
            {
                heightArray[i] = new HystogramNode(i + 1, heightValuesArray[i]);
            }
            return heightArray;
        }

        public static int MaximumRectangleArea(HystogramNode[] array)
        {
            int countOfHystogramElements = array.Length; //количество прямоугольников гистограммы
            Stack<HystogramNode> stack = new Stack<HystogramNode>(); //заводим стек из прямоугольников гистограммы
            HystogramNode minusOneElement = new HystogramNode(0, -1); //добавляем элемент с высотой -1, который никогда не будет вытолкнут из стека
            stack.Push(minusOneElement); //добавляем элемент высотой -1 в стек
            int minimumValueOfArrayElement = FindMinimumHystogramBlock(array);
            int maxRectangleArea = minimumValueOfArrayElement * (countOfHystogramElements - 2);

            for (int i = 0; i < countOfHystogramElements; i++)
            {
                if (array[i].NodeHeight >= stack.Peek().NodeHeight)
                {
                    stack.Push(array[i]);
                }
                else
                {
                    while (array[i].NodeHeight < stack.Peek().NodeHeight)
                    {
                        int result = stack.Peek().NodeHeight * (i - stack.Peek().NodeIndex + 1);
                        if(result > maxRectangleArea)
                        {
                            maxRectangleArea = result;
                        }
                        stack.Pop();
                    }

                    int index = 0;

                    for (int j = i; array[j].NodeHeight >= array[i].NodeHeight; j--)
                    {
                        if(i == countOfHystogramElements - 1)
                        {
                            break;
                        }
                        int turnResult = array[i].NodeHeight * (index + 1);
                        if(turnResult > maxRectangleArea)
                        {
                            maxRectangleArea = turnResult;
                        }
                        index++;
                    }
                    stack.Push(array[i]);
                }
            }
            return maxRectangleArea;
        }

        private static int FindMinimumHystogramBlock(HystogramNode[] array)
        {
            int result = array[1].NodeHeight;

            for(int i = 1; i < array.Length - 1; i++)
            {
                if(array[i].NodeHeight < result)
                {
                    result = array[i].NodeHeight;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return $"({NodeIndex},{NodeHeight})";
        }
    }
}
