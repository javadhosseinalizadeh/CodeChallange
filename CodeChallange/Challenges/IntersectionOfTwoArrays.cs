using System;
using System.Collections.Generic;

namespace CodeChallange.Challenges
{
    public class IntersectionOfTwoArrays
    {
        public static List<int> CheckIntersection(int[] array1, int[] array2)
        {
            Dictionary<int, int> numsMap = new Dictionary<int, int>();
            List<int> intersectionNums = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                if (numsMap.ContainsKey(array1[i]))
                    numsMap[array1[i]]++;
                else
                    numsMap.Add(array1[i], 1);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (numsMap.ContainsKey(array2[i]))
                {
                    intersectionNums.Add(array2[i]);

                    numsMap[array2[i]]--;

                    if (numsMap[array2[i]] == 0)
                        numsMap.Remove(array2[i]);
                }
            }

            return intersectionNums;
        }
    }
}