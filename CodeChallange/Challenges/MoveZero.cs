using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public class MoveZero
    {
        public static int[] MoveZeroToEnd(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return nums;

            int insertPos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertPos] = nums[i];
                    insertPos++;
                }
            }

            while (insertPos < nums.Length)
            {
                nums[insertPos] = 0;
                insertPos++;
            }

            return nums;
        }
    }
}
