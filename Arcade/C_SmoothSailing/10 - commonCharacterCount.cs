using System.Xml;

namespace CodeSignal.Arcade.C_SmoothSailing
{
    internal class Problem10
    {
        public static int commonCharacterCount(string s1, string s2)
        {
            int count = 0;
            foreach (char c in s1)
            {
                int index = s2.IndexOf(c);
                if (index >= 0)
                {
                    s2 = s2.Remove(index, 1);
                    count++;
                }
            }

            return count;
        }
    }
}