using System;

namespace CodeSignal.Arcade.E_IslandOfKnowledge
{
    internal class Problem23
    {
        public static int[][] boxBlur(int[][] image)
        {
            int inputRows = image.Length;
            int inputCols = image[0].Length;
            int outputRows = inputRows - 2;
            int outputCols = inputCols - 2;
            System.Console.WriteLine("Input  = " + inputRows + "x" + inputCols);
            System.Console.WriteLine("Output = " + outputRows + "x" + outputCols);
            int[][] output = new int[outputRows][];

            for (int i = 0; i < outputRows; i++)
            {
                int[] currentRow = new int[outputCols];
                for (int j = 0; j < outputCols; j++)
                {
                    decimal result = image[i + 0][j] + image[i + 0][j + 1] + image[i + 0][j + 2] +
                                 image[i + 1][j] + image[i + 1][j + 1] + image[i + 1][j + 2] +
                                 image[i + 2][j] + image[i + 2][j + 1] + image[i + 2][j + 2];
                    currentRow[j] = (int)Math.Truncate(result / 9);
                }
                output[i] = currentRow;
            }
            return output;
        }

        public static void toString(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image[i].Length; j++)
                {
                    System.Console.Write("[" + image[i][j] + "] ");
                }
                System.Console.WriteLine();
            }
        }
    }
}