using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.CheckEntry
{
    internal static class CheckType
    {
        public static string CheckString(string promt)
        {
            Console.Write(promt);
            string text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                return CheckString("Пустая строка. Попробуйте снова: ");
            }
            return text;
        }

        public static int CheckInt(string promt)
        {
            Console.Write(promt);
            string text = Console.ReadLine();
            if (!int.TryParse(text, out int number))
            {
                return CheckInt("Некоррктный ввод");
            }
            return number;
        }
    }
}