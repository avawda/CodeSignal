namespace CodeSignal.Arcade.C_SmoothSailing
{
    internal class Problem11
    {
        public static bool isLucky(int n)
        {
            string input = n.ToString();
            if (input.Length % 2 != 0)
                return false;
            int midpoint = input.Length / 2;
            int segment1 = 0;
            int segment2 = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i < midpoint)
                    segment1 += input[i];
                else
                    segment2 += input[i];
            }
            return segment1 == segment2;
        }
    }
}