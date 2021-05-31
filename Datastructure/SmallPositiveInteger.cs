using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class SmallPositiveInteger
    {
        static void Main(string[] args)
        {
            int[] nums = { };
            int result = findSmallest(nums);
            Console.WriteLine(result);
        }

        public static int findSmallest(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int val = 0;

            Array.Sort(nums);

            nums = nums.Distinct().ToArray();

            int smallest = nums[0];

            if (smallest < 1)
            {
                return 0;
            }
            else
            {
                for (int i = 1; i <= nums.Length + 1; i++)
                {
                    if (nums.Length < i)
                    {
                        val = i;
                        break;
                    }

                    if (nums[i - 1] != i)
                    {
                        val = i;
                        break;
                    }
                }
            }

            return val;
        }
    }
}
