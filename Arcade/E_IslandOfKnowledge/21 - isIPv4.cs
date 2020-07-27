using System;
using System.ComponentModel.DataAnnotations;

namespace CodeSignal.Arcade.E_IslandOfKnowledge
{
    internal class Problem21
    {
        public static bool isIPv4Address(string inputString)
        {
            // Check if 4 elements
            int dotCount = 0;
            foreach (char c in inputString)
                if (c == '.') dotCount++;

            if (dotCount != 3)
                return false;

            // Analyse each segment
            int lastDot = 0;
            int ipSegment = 0;
            string ipText = "";
            for (int i = 0; i < 4; i++)
            {
                int nextDot = inputString.IndexOf('.', lastDot);
                //Last segment reached
                if (nextDot == -1)
                    nextDot = inputString.Length;
                int length = nextDot - lastDot;
                try
                {
                    ipText = inputString.Substring(lastDot, length);
                    if (ipText.Length > 3)
                        return false;
                    ipSegment = Int16.Parse(ipText);
                }
                catch (FormatException)
                {
                    return false;
                }

                lastDot = nextDot + 1;

                if (ipSegment > 255 || ipSegment < 0 || ipText.Length != ipSegment.ToString().Length)
                    return false;
            }
            return true;
        }
    }
}