using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWayAPI.ConvertBase36
{
    public static class Base36
    {
        private const string CharList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Encode the given number into a Base36 string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static String Encode(int? input)
        {
            if (input < 0) throw new ArgumentOutOfRangeException("input", input, "input cannot be negative");
            int x = input ?? 1;
            char[] clistarr = CharList.ToCharArray();
            var result = new Stack<char>();
            while (x != 0)
            {
                result.Push(clistarr[x % 36]);
                x /= 36;
            }
            return new string(result.ToArray());
        }

        /// <summary>
        /// Decode the Base36 Encoded string into a number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Int64 Decode(string input)
        {
            var reversed = input.Reverse();
            long result = 0;
            int pos = 0;
            foreach (char c in reversed)
            {
                result += CharList.IndexOf(c) * (long)Math.Pow(36, pos);
                pos++;
            }
            return result;
        }
    }
}