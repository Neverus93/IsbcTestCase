using System;
using System.Collections.Generic;

namespace SecondTask
{
    public static class HystogramMathHelper
    {
        public static int[] HeightArrayGenerator(int count, int maxValue)
        {
            Random random = new Random();
            int[] heightArray = new int[count];
            for (int i = 0; i < heightArray.Length; i++)
            {
                heightArray[i] = random.Next(0, maxValue + 1);
            }
            return heightArray;
        }

        public static int MaximumRectangleArea(int[] array)
        {
            return 0;
        }

        private static int CalculateBlockArea(int blockWidth, int blockHeight)
        {
            return blockWidth * blockHeight;
        }
    }
}
