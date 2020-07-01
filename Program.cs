using System;
using CodeSignal.Arcade.C_SmoothSailing;
using CodeSignal.Arcade.D_ExploringTheWaters;

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

            int[] input1 = { 1, 2, 3 };
            int[] input2 = { 2, 1, 3 };
            int[] input3 = { 3, 2, 1 };
            int[] input4 = { 1, 2, 2 };
            //Console.WriteLine(Problem16.areSimilar(input1, input2));
            Console.WriteLine(Problem16.areSimilar(input1, input3));
            //Console.WriteLine(Problem16.areSimilar(input1, input4));
            Console.WriteLine();
        }
    }
}