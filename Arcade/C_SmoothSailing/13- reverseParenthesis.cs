using System.Linq;
using System.Reflection.PortableExecutable;
using System.Xml;

namespace CodeSignal.Arcade.C_SmoothSailing
{
    internal class Problem13
    {
        public static string reverseInParentheses(string inputString)
        {
            // Credit to this clip, which solved the problem in Java https://www.youtube.com/watch?v=3k8SCh3dUAw&feature=youtu.be

            int lastLeftBracket = inputString.LastIndexOf('(');
            if (lastLeftBracket < 0) // No brackets found
                return inputString;
            int nexRightBracket = inputString.IndexOf(')', lastLeftBracket);

            while (lastLeftBracket != -1)
            {
                string reverse = inputString.Substring(lastLeftBracket + 1, nexRightBracket - lastLeftBracket - 1);
                reverse = new string(reverse.Reverse().ToArray());
                string prefix = inputString.Substring(0, lastLeftBracket);
                string suffix = inputString.Substring(nexRightBracket + 1);

                inputString = prefix + reverse + suffix;

                lastLeftBracket = inputString.LastIndexOf('(');
                if (lastLeftBracket < 0)
                    break;
                nexRightBracket = inputString.IndexOf(')', lastLeftBracket);
            }
            return inputString;
        }
    }
}