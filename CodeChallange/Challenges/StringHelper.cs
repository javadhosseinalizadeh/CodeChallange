using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class StringHelper
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
