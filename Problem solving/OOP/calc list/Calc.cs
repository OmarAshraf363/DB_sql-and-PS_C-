using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_using_Classs_whithout_creating_ob
{
    internal static class Calc
    {
      
        public static int Add(List<int> nums)
        {
            int total = 0;
            foreach (int i in nums)
            {
                total += i;
            }
            return total;
        }
        public static int Sub(List<int> nums)
        {
            int total = nums[0];
            for (int i=1; i<nums.Count;i++)
            {
                total -= nums[i];
            }
            return total;
        }
        public static double Mul(List<int> nums)
        {
            double total = 1;
            for (int i=0;i<nums.Count;i++)
            {
                total *= nums[i];
            }
            return total;
        }
        public static double Div(List<int> nums)
        {
            double total = nums[0];
            for(int i = 1; i < nums.Count; i++)
            {
                total /= nums[i];
            }
            return total;
        }
    }
}
