using System.Linq;

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
    }
}
