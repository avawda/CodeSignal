using System;
using CodeSignal.Arcade.A_TheJourneyBegins;
using CodeSignal.Arcade.B_EdgeOfTheOcean;

namespace CodeSignal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(Problem4.AdjacentElementsProduct(input));
        }
    }
}