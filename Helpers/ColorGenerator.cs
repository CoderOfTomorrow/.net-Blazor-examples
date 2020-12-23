using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_Examples.Helpers
{
    public static class ColorGenerator
    {
        public static string Generator(int stringLength)
        {
            Random rnd = new Random();
            const string allowedChars = "0123456789ABCDEF";

            char[] chars = new char[stringLength];
            int setLength = allowedChars.Length;

            for (int i = 0; i < stringLength; ++i)
            {
               chars[i] = allowedChars[rnd.Next(setLength)];
            }

            string randomString = new string(chars, 0, stringLength);

            return randomString;
        }
    }
}
