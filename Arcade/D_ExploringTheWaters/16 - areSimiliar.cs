using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.Arcade.D_ExploringTheWaters
{
    internal class Problem16
    {
        public static bool areSimilar(int[] a, int[] b)
        {
            if (a.SequenceEqual(b))
                return true;
            if (a.Length != b.Length)
                return false;

            // Find position of mismatches
            var mismatchedIndex = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    mismatchedIndex.Add(i);
            }

            // More than 2 mismatches so no need to proceed
            if (mismatchedIndex.Count > 2)
                return false;
            else // Check if the opposite numbers can be swapped
            {
                int elema1 = a[mismatchedIndex[0]];
                int elema2 = a[mismatchedIndex[1]];

                int elemb1 = b[mismatchedIndex[0]];
                int elemb2 = b[mismatchedIndex[1]];
                return ((elema1 == elemb2) && (elema2 == elemb1));
            }
        }
    }
}