using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDelegate
{
    public delegate int DelCompare<T>(T o1, T o2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax<int>(new int[] { 1, 2, 3, 4 }, (o1, o2) => { return o1 - o2; }));
            Console.ReadKey();
        }

        static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
