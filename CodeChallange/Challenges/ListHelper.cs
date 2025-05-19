using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class ListHelper
    {
        public static List<T> RemoveDuplicatesLinq<T>(List<T> input)
        {
            if (input is null || input.Count == 0) return [];

            return input.Distinct().ToList();
        }

        public static List<T> RemoveDuplicatesManual<T>(List<T> input)
        {
            if (input is null || input.Count == 0)
                return [];

            var seen = new HashSet<T>();
            var result = new List<T>();

            foreach (var item in input)
            {
                if (seen.Add(item)) 
                    result.Add(item);
            }

            return result;
        }
    }
}
