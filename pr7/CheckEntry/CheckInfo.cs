using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.CheckEntry
{
    internal static class CheckInfo
    {
              
        public static bool CheckEmail(string text)
        {
            if (text.Contains('@') && text.Contains('.'))
            {
                return true;
            }
            return false;
        }

        public static bool CheckPassword(string text1, string text2)
        {
            if (text1 == text2)
            {
                return true;
            }
            return false;
        }

        public static bool CheckNumber(string text)
        {
            var n = text.ToCharArray();

            if (n.Length == 12 || n[0] == '+')
            {
                for (int i = 1; i < n.Length; i++)
                {
                    char c = n[i];
                    if (c < '0' || c > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

    }
}
