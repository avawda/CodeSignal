using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CodeSignal.Arcade.D_ExploringTheWaters
{
    internal class Problem18
    {
        public static bool palindromeRearranging(string inputString)
        {
            // Single character or already palindrome
            if (inputString.Length == 1 || isPalindrome(inputString))
                return true;

            // All unique characters so impossible to be palindrome
            if (inputString.Length == inputString.Distinct().Count())
                return false;

            // check for unique characters.  If more than one unique character, impossible to be Palindrome
            string distinctInput = new string(inputString.Distinct().ToArray());
            Dictionary<char, int> inputDic = new Dictionary<char, int>();
            foreach (char c in distinctInput)
            {
                inputDic.Add(c, countInstances(inputString, c));
            }
            int uniqueChars = 0;
            bool evenChars = inputString.Length % 2 == 0;

            foreach (var kvp in inputDic)
            {
                System.Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                if (kvp.Value == 1)
                    uniqueChars++;

                // If more than one unique is found, reject
                if (uniqueChars == 2)
                    return false;

                // Even number of characters
                if ((evenChars) && (kvp.Value % 2 != 0))
                    return false;
            }

            return true;
        }

        private static bool isPalindrome(string input)
        {
            return input.SequenceEqual(input.Reverse());
        }

        private static int countInstances(string inputString, char findChar)
        {
            int count = 0;
            foreach (char c in inputString)
                if (c == findChar) count++;

            return count;
        }
    }
}