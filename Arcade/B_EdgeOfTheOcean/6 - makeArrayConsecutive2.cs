using System;

namespace CodeSignal.Arcade.B_EdgeOfTheOcean
{
    internal class Problem6
    {
        public static int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            Console.WriteLine(string.Join(",", statues));
            int missing = 0;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                missing += statues[i + 1] - statues[i] - 1;
            }
            return missing;
        }
    }
}