using System;
using System.Collections.Generic;

namespace CodeSignal.Arcade.C_SmoothSailing
{
    internal class Problem9
    {
        public static string[] allLongestStrings(string[] inputArray)
        {
            int maxLength = 0;
            List<string> output = new List<string>();
            foreach (string s in inputArray)
            {
                maxLength = Math.Max(maxLength, s.Length);
            }

            foreach (string s in inputArray)
            {
                if (s.Length == maxLength)
                {
                    output.Add(s);
                }
            }
            return output.ToArray();
        }
    }
}