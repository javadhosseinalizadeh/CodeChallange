using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;

            k = k % n;

            Reverse(nums, 0, n - 1);

            Reverse(nums, 0, k - 1);

            Reverse(nums, k, n - 1);

            Console.WriteLine(string.Join(", ", nums));
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];

                nums[start] = nums[end];

                nums[end] = temp;

                start++;
                end--;
            }
        }
    }
}