using System.Linq;

namespace CodeSignal.Arcade.A_TheJourneyBegins
{
    internal class Problem3
    {
        public static bool CheckPalindrome(string inputString)
        {
            inputString = inputString.ToLower();
            string reverse = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverse = reverse + inputString[i];
            }

            if (reverse.Equals(inputString))
                return true;
            else
                return false;

            // C# actually contains a reverse method that can be used as below
            // return (inputString.SequenceEqual(inputString.Reverse()));
        }
    }
}