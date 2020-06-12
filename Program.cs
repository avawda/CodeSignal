using System;
using CodeSignal.Arcade.A_TheJourneyBegins;
using CodeSignal.Arcade.B_EdgeOfTheOcean;

namespace CodeSignal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = { 6, 2, 3, 8 };
            Console.WriteLine(string.Join(",", input));
            Console.WriteLine(Problem6.makeArrayConsecutive2(input));
        }
    }
}