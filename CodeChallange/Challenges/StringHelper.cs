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

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            var cleaned = new string(input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            int left = 0, right = cleaned.Length - 1;
            while (left < right)
            {
                if (cleaned[left] != cleaned[right]) return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
