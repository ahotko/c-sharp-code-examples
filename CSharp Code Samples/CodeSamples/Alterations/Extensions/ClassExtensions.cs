using System;
using System.Linq;
using System.Text;

namespace CodeSamples.Alterations.Extensions
{
    public static class ClassExtensions
    {
        public static int CountUppercaseCharacters(this string str)
        {
            string allCaps = string.Concat(str.Where(c => (c >= 'A' && c <= 'Z')));
            return allCaps.Length;
        }

        public static int CountCharacters(this string str, char chr)
        {
            string allChars = string.Concat(str.Where(c => (c == chr)));
            return allChars.Length;
        }

        public static string PadRightWithString(this string value, string padding, int paddingCount)
        {
            var result = new StringBuilder(value);
            for (int i = 0; i < paddingCount; i++)
            {
                result.Append(padding);
            }
            return result.ToString();
        }

        public static void WriteToConsole(this string value)
        {
            Console.WriteLine($"Contents Of String = {value}");
        }
    }
}
