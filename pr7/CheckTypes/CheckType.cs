using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.CheckTypes
{
    internal static class CheckType
    {
        public static string? CheckString(string promt)
        {
            Console.Write(promt);
            string? text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                return CheckString("Пустая строка. Попробуйте снова: ");
            }
            return text;
        }
    }
}