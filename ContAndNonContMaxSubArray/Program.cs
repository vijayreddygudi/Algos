using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContAndNonContMaxSubArray
{
    class Program
    {
        public static void Main(String[] args)
        {
            int setCount = Int32.Parse(Console.ReadLine());
            while (setCount > 0)
            {
                int n = Int32.Parse(Console.ReadLine());
                string[] strArray = Console.ReadLine().Split(' ');
                int[] nums = new int[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    nums[i] = Int32.Parse(strArray[i]);
                }
                Console.Write(ContSum(nums) + " ");
                Console.WriteLine(NonContSum(nums));
                setCount--;
            }

        }

        static int ContSum(int[] nums)
        {
            int result = 0;
            int LastMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result += nums[i];
                    if (LastMax > result)
                    {


                    }
                }
            }
            return result;
        }

        static int NonContSum(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result += nums[i];
                }
            }
            return result;
        }
    }
}
