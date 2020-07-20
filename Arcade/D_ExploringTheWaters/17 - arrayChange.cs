namespace CodeSignal.Arcade.D_ExploringTheWaters
{
    internal class Problem17
    {
        public static int arrayChange(int[] inputArray)
        {
            int moves = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] >= inputArray[i + 1])
                {
                    moves += inputArray[i] - inputArray[i + 1] + 1;
                    inputArray[i + 1] = inputArray[i] + 1;
                }
            }
            return moves;
        }
    }
}