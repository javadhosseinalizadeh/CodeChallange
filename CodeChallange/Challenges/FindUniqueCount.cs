using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeChallange.Challenges
{
    public class FindUniqueCount
    {
        public static void UniqueCount(int[] input)
        {
            Array.Sort(input);

            if (input.Length == 0)
            {
                Console.WriteLine("Unique Count: 0");
                return;
            }

            int uniqueIndex = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[uniqueIndex] != input[i])
                {
                    input[uniqueIndex + 1] = input[i];
                    uniqueIndex++;

                }
            }

            Console.WriteLine($"Unique Count: {uniqueIndex + 1}");
        }
    }
}
