namespace CodeSignal.Arcade.D_ExploringTheWaters
{
    internal class Problem14
    {
        public static int[] alternatingSums(int[] a)
        {
            int sum1 = a[0];
            int sum2 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 == 0)
                    sum1 += a[i];
                else
                    sum2 += a[i];
            }
            int[] output = { sum1, sum2 };
            return output;
        }
    }
}