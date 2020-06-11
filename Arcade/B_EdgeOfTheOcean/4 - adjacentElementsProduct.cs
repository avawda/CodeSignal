using System;

namespace CodeSignal.Arcade.B_EdgeOfTheOcean
{
    internal class Problem4
    {
        public static int AdjacentElementsProduct(int[] inputArray)
        {
            int product = inputArray[0] * inputArray[1];
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                product = Math.Max(product, inputArray[i] * inputArray[i + 1]);
            }
            return product;
        }
    }
}