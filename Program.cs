using System;
using CodeSignal.Arcade.E_IslandOfKnowledge;

namespace CodeSignal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] input = { -1, 150, 190, 170, -1, -1, 160, 180 };
            //Console.Write(string.Join(",", Problem12.sortByHeight(input)));
            //Console.WriteLine();
            //int[] input = { 50, 60, 60, 45, 70 };
            //string[] picture = { "abc", "ded" };
            //Console.Write(string.Join(",\n", Problem15.addBorder(picture)));

            //int[] input1 = { 1, 1, 1 };
            //int[] input2 = { -1000, 0, -2, 0 };

            string input = ".254.255.0";
            Console.WriteLine(Problem21.isIPv4Address(input));
            Console.WriteLine();
        }
    }
}