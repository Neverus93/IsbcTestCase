using System;
using System.Collections.Generic;

namespace SecondTask
{
    public class HystogramNode
    {
        public int Index { get; set; }
        public int Height { get; set; }

        public HystogramNode(int index, int height)
        {
            Index = index;
            Height = height;
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
            int maxRectangleArea = 0;
            Stack<HystogramNode> stack = new Stack<HystogramNode>();
            HystogramNode nullElement = new HystogramNode(0, 0);
            stack.Push(nullElement);
            stack.Push(array[0]);

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i + 1].Height > stack.Peek().Height)
                {
                    stack.Push(array[i + 1]);
                }
                else
                {
                    while (array[i + 1].Height <= stack.Peek().Height)
                    {
                        maxRectangleArea = stack.Peek().Height * (i + 1);
                        stack.Pop();
                    }
                }
            }
            return maxRectangleArea;
        }
    }
}
