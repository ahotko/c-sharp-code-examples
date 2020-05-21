using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

        public static string GetDescription<T>(this T enumerationValue) where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }
    }
}
