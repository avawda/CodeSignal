using System;

namespace CodeSignal.Arcade.E_IslandOfKnowledge
{
    internal class Problem19
    {
        public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            if (Math.Max(yourLeft, yourRight) == Math.Max(friendsLeft, friendsRight) && (Math.Min(yourLeft, yourRight) == Math.Min(friendsLeft, friendsRight)))
                return true;

            return false;
        }
    }
}