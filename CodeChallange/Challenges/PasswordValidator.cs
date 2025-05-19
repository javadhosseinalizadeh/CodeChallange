using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class PasswordValidator
    {
        public static bool IsStrongPassword(string password)
        {
            if(string.IsNullOrEmpty(password) || password.Length < 8) return false;

            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasLower = Regex.IsMatch(password, "[a-z]");
            bool hasDigit = Regex.IsMatch(password, "[0-9]");
            bool hasSpecial = Regex.IsMatch(password, "[^a-zA-Z0-9]");

            var test = hasLower;

            return hasUpper && hasLower && hasDigit && hasSpecial;

        }
    }
}
