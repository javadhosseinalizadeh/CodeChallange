using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public class ContainDuplicate
    {
        public static bool CheckDuplicate(int[] input)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < input.Length; i++) { 
                if(numbers.Contains(input[i])) { return true; }
                numbers.Add(input[i]);
            }
            return false;
        }
    }
}
