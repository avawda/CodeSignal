using System;
using CodeSignal.Arcade.B_EdgeOfTheOcean;

namespace CodeSignal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = { 10, 1, 2, 3, 4, 5 };
            Console.WriteLine(Problem7.almostIncreasingSequence(input));
        }
    }
}