using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public class Question2
    {
        public void MultipleOf3And5()
        {
            int k = 0;
            int[] nums = new int[100];
            for (int i = 0; i < nums.Length; i++)
            {
                k += 1;
                nums[i] = k;
                if (k % 3 == 0 && k % 5 == 0)
                {
                    Console.Write("AutoSweet, ");
                }
                else if (k % 3 == 0)
                {
                    Console.Write("Auto, ");
                }
                else if (k % 5 == 0)
                {
                    Console.Write("Sweet, ");
                }
                else
                {
                    Console.Write(nums[i] + ", ");
                }
            }
        }
    }
}
