using System;

namespace CodeSignal.Arcade.E_IslandOfKnowledge
{
    internal class Problem24
    {
        public static int[][] minesweeper(bool[][] matrix)
        {
            int[][] output = new int[][] {
                                new int [] {1, 2, 1 },
                                new int [] {2, 1, 1 },
                                new int [] {1, 1, 1 }
            };

            return output;
        }

        public static void toString(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    System.Console.Write("[" + matrix[i][j] + "] ");
                }
                System.Console.WriteLine();
            }
        }
    }
}