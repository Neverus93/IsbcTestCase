using System;
using System.Collections.Generic;

namespace SecondTask
{
    public class HystogramNode
    {
        public int NodeHeight { get; set; }
        public int NodeWidth { get; set; }
        public HystogramNode(int width, int height)
        {
            NodeHeight = height;
            NodeWidth = width;
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
            HystogramNode nullElement = new HystogramNode(countOfHystogramElements + 1, 0);
            stack.Push(minusOneElement); //добавляем элемент высотой -1 в стек
            
            for(int i = 1; i <= countOfHystogramElements + 1; i++)
            {
                //if(i <= countOfHystogramElements)
                //{
                //    array[i].NodeHeight = 
                //}
                //else
            }

            //for(int i = 0; i < array.Length; i++)
            //{
            //    if (array[i].NodeHeight > stack.Peek().NodeHeight)
            //    {
            //        stack.Push(array[i]);
            //    }
            //    else if(array[i].NodeHeight <= stack.Peek().NodeHeight)
            //    {
            //        //for(int stackIndex = 0; stackIndex < stack.Count; stackIndex++)
            //        //{
            //        //    if(stack.Peek().NodeHeight > array[i].NodeHeight)
            //        //    {
            //        //        int betweenResult = stack.Peek().NodeHeight * i;
            //        //        if (betweenResult >= maxRectangleArea)
            //        //        {
            //        //            maxRectangleArea = betweenResult;
            //        //        }
            //        //        stack.Pop();
            //        //    }
            //        //}
            //        //stack.Push(array[i]);
            //    }
            //}

            ////for (int i = 0; i < array.Length; i++)
            ////{
            ////    if (array[i].NodeHeight >= stack.Peek().NodeHeight)
            ////    {
            ////        stack.Push(array[i]);
            ////    }
            ////    else
            ////    {
            ////        int maxRectangleOfCurrentHystogram = StackHystogramBlockArea(stack, stack.Count);
            ////        if (maxRectangleArea < maxRectangleOfCurrentHystogram)
            ////        {
            ////            maxRectangleArea = maxRectangleOfCurrentHystogram;
            ////        }
            ////    }
            ////}
            ////int stackHystogramBlockArea = StackHystogramBlockArea(stack, stack.Count);
            ////if (maxRectangleArea < stackHystogramBlockArea)
            ////{
            ////    maxRectangleArea = stackHystogramBlockArea;
            ////}
            return maxRectangleArea;
        }

        public override string ToString()
        {
            return $"({NodeWidth},{NodeHeight})";
        }

        private static int StackHystogramBlockArea(Stack<HystogramNode> stack, int arrayLength)
        {
            int stackHystogramBlockArea = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (stackHystogramBlockArea <= stack.Peek().NodeHeight * (i + 1))
                {
                    stackHystogramBlockArea = stack.Pop().NodeHeight * (i + 1);
                }
            }
            return stackHystogramBlockArea;
        }

        private static int FindMinValueOfArray(HystogramNode[] array)
        {
            int minValue = array[0].NodeHeight;
            for (int i = 0; i < array.Length; i++)
            {
                if (minValue > array[i].NodeHeight)
                {
                    minValue = array[i].NodeHeight;
                }
            }
            return minValue;
        }
    }
}
