using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public class Question1
    {
        public void CountTo100() 
        {
        int k = 0;
        int[] nums = new int[100];
        for (int i = 0; i<nums.Length; i++)
			{
                k += 1;
                nums[i] = k;
                Console.Write(nums[i] + ", ");
			}
            
        }
    }
}
