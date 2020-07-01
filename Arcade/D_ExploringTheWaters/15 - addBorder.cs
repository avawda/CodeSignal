using System.Collections.Generic;
using System.Linq.Expressions;

namespace CodeSignal.Arcade.D_ExploringTheWaters
{
    internal class Problem15
    {
        public static string[] addBorder(string[] picture)
        {
            int rowLength = picture[0].Length + 2;
            //List<string> picList = new List<string>(picture);
            List<string> picList = new List<string>();
            string headerFooter = new string('*', rowLength);

            foreach (string element in picture)
            {
                string entry = "*" + element + "*";
                picList.Add(entry);
            }
            picList.Insert(0, headerFooter);
            picList.Insert(picture.Length + 1, headerFooter);
            return picList.ToArray();
        }
    }
}