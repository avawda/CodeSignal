using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.Arcade.B_EdgeOfTheOcean
{
    internal class Problem7
    {
        public static bool almostIncreasingSequence(int[] sequence)
        {
            List<int> seq = new List<int>(sequence);
            List<int> seqSorted = seq.Distinct().ToList();

            for (int i = 0; i < sequence.Length; i++)
            {
                seq = new List<int>(sequence);
                seq.RemoveAt(i);
                seqSorted = seq.Distinct().ToList();
                seqSorted.Sort();
                if (seq.SequenceEqual(seqSorted))
                    return true;
            }

            return false;
        }
    }
}