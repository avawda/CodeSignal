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

    /*public static bool almostIncreasingSequence(int[] sequence)
    {
        //Console.WriteLine(string.Join(",", seq));
        //Console.WriteLine(string.Join(",", seqSorted));

        for (int i = 0; i < sequence.Length; i++)
        {
            List<int> seq1 = new List<int>();
            List<int> seq2 = new List<int>();
            for (int j = 0; j < i; j++)
            {
                seq1.Add(sequence[j]);
            }
            for (int j = i + 1; j < sequence.Length; j++)
            {
                seq2.Add(sequence[j]);
            }
            var seqMerged = seq1.Concat(seq2);
            List<int> seqSorted = new List<int>(seqMerged.Distinct().ToList());
            seqSorted.Sort();

            Console.WriteLine("i = " + i);
            Console.WriteLine(string.Join(",", seq1));
            Console.WriteLine(string.Join(",", seq2));
            Console.WriteLine(string.Join(",", seqMerged));
            Console.WriteLine(string.Join(",", seqSorted));

            if (seqMerged.SequenceEqual(seqSorted))
                return true;
        }
        return false;
    }*/
}