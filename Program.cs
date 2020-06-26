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
            int[] input = { 50, 60, 60, 45, 70 };
            Console.Write(string.Join(",", Problem14.alternatingSums(input)));
            Console.WriteLine();
        }
    }
}