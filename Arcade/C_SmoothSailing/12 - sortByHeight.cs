using System.Collections.Generic;
using System.Linq.Expressions;

namespace CodeSignal.Arcade.C_SmoothSailing
{
    internal class Problem12
    {
        public static int[] sortByHeight(int[] input)
        {
            // Edge case, single element
            if (input.Length == 1)
                return input;

            // Determine position of trees and people
            List<int> treePos = new List<int>();
            List<int> people = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0)
                    treePos.Add(i);
                else
                    people.Add(input[i]);
            }
            people.Sort();

            // Reinsert the trees at correct locations
            foreach (int tree in treePos)
            {
                people.Insert(tree, -1);
            }
            return people.ToArray();
        }
    }
}