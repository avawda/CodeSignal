using System;

namespace CodeSignal.Arcade.E_IslandOfKnowledge
{
    internal class Problem20
    {
        private static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int absMax = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                int result = Math.Abs(inputArray[i] - inputArray[i - 1]);
                absMax = Math.Max(absMax, result);
            }
            return absMax;
        }
    }
}