using System;
using System.Linq;
using System.Runtime.Versioning;

namespace CodeSignal.Arcade.E_IslandOfKnowledge
{
    internal class Problem22
    {
        public static int avoidObstacles(int[] inputArray)
        {
            for (int i = 2; i < inputArray.Max(); i++)
            {
                Boolean factor = false;
                foreach (int num in inputArray)
                {
                    if (num % i == 0)
                    {
                        factor = true;
                        break;
                    }
                }
                if (!factor)
                    return i;
            }
            return inputArray.Max() + 1;
        }
    }
}