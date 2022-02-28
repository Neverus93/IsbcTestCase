using System;
using System.Collections.Generic;

namespace SecondTask
{
    public class HystogramNode
    {
        public int NodeIndex { get; set; }
        public int NodeHeight { get; set; }

        public HystogramNode(int index, int height)
        {
            NodeIndex = index;
            NodeHeight = height;
        }

        public static HystogramNode[] GenerateHeightArray(int count, int maxValue)
        {
            Random random = new Random();
            HystogramNode[] heightArray = new HystogramNode[count];
            for (int i = 0; i < heightArray.Length; i++)
            {
                heightArray[i] = new HystogramNode(i + 1, random.Next(1, maxValue + 1));
            }
            return heightArray;
        }

        public static int MaximumRectangleArea(HystogramNode[] array)
        {
            int maxRectangleArea = FindMinValueOfArray(array) * array.Length;
            Stack<HystogramNode> stack = new Stack<HystogramNode>();
            HystogramNode nullElement = new HystogramNode(0, 0);
            stack.Push(nullElement);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].NodeHeight >= stack.Peek().NodeHeight)
                {
                    stack.Push(array[i]);
                }
                else
                {
                    int maxRectangleOfCurrentHystogram = StackHystogramBlockArea(stack, stack.Count);
                    if(maxRectangleArea < maxRectangleOfCurrentHystogram)
                    {
                        maxRectangleArea = maxRectangleOfCurrentHystogram;
                    }
                }
            }
            int stackHystogramBlockArea = StackHystogramBlockArea(stack, stack.Count);
            if (maxRectangleArea < stackHystogramBlockArea)
            {
                maxRectangleArea = stackHystogramBlockArea;
            }
            return maxRectangleArea;
        }

        public override string ToString()
        {
            return $"({NodeIndex},{NodeHeight})";
        }

        private static int StackHystogramBlockArea(Stack<HystogramNode> stack, int arrayLength)
        {
            int stackHystogramBlockArea = 0;
            for(int i = 0; i < arrayLength; i++)
            {
                if(stackHystogramBlockArea <= stack.Peek().NodeHeight * (i + 1))
                {
                    stackHystogramBlockArea = stack.Pop().NodeHeight * (i + 1);
                }
            }
            return stackHystogramBlockArea;
        }

        private static int FindMinValueOfArray(HystogramNode[] array)
        {
            int minValue = array[0].NodeHeight;
            for(int i = 0; i < array.Length; i++)
            {
                if(minValue > array[i].NodeHeight)
                {
                    minValue = array[i].NodeHeight;
                }
            }
            return minValue;
        }
    }
}
