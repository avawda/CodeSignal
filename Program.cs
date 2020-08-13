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

            int[] input1 = { 2, 3 };
            int[] input2 = { 1, 4, 10, 6, 2 };

            int[][] image = new int[][] {
                                new int [] {1, 1, 1 },
                                new int [] { 1, 7, 1 },
                                new int [] { 1, 1, 1 }
                                };
            int[][] image2 = new int[][] {
                                new int [] {36,0,18,9},
                                new int [] {27,54,9,0},
                                new int [] {81,63,72,45}
                                };
            Console.WriteLine("Original Image");
            Problem23.toString(image2);
            Console.WriteLine();
            Console.WriteLine("Blurred Image");
            int[][] blurred = Problem23.boxBlur(image2);
            Problem23.toString(blurred);
            Console.WriteLine();
        }
    }
}