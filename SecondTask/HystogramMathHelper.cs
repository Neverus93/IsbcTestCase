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
            int maxRectangleArea = -1;
            for(int j = 0; j < array.Length; j++)
            {
                int height = array[j];
                for(int i = j; i < array.Length; i++)
                {
                    bool isLast = i == array.Length - 1;
                    if(array[i] < array[j])
                    {
                        int width = i - j;
                        int resultArea = CalculateBlockArea(width, height);
                        if(resultArea > maxRectangleArea)
                        {
                            maxRectangleArea = resultArea;
                        }
                    }
                    if (isLast)
                    {
                        int width = i - j + 1;
                        int resultArea = CalculateBlockArea(width, height);
                        if(resultArea > maxRectangleArea)
                        {
                            maxRectangleArea = resultArea;
                        }
                    }
                }
            }
            return maxRectangleArea;
        }

        private static int CalculateBlockArea(int blockWidth, int blockHeight)
        {
            return blockWidth * blockHeight;
        }
    }
}
