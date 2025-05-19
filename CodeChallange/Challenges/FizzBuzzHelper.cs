using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class FizzBuzzHelper
    {
        public static void RunFizzBuzz(int from = 0, int to = 100)
        {
            for (int i = from; i<=to; i++)
            {
                if(i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
