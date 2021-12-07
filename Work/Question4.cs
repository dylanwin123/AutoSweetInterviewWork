using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
  public class Question4
    {
        public List<int> Duplicates(List<int> nums)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                int k = 0;
                foreach (int number in nums)
                {
                    if (number == nums[i])
                    {
                        k += 1;
                    }
                }
                if (k == 1)
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }
    }
}
