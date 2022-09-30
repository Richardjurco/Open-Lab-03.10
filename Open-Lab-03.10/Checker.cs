using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int charnum = 0;
            foreach (char  chars in str)
            { if (chars == letter)
                    charnum++;
            }
            return charnum;
        }
    }
}
