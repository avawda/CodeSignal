namespace CodeSignal.Arcade.A_TheJourneyBegins
{
    internal class Problem2
    {
        public static int CenturyFromYear(int year)
        {
            if (year % 100 == 0)
                return year / 100;
            else
                return (year / 100) + 1;
        }
    }
}