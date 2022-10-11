using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Activity5
{
    public class Program
    {
        public static void Main(string[]args)
        {
            List<int> list = givenlist (new List<int> (new int[] {10, 20, 35, 65, 53, 48, 5, 1}));
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static List<int> givenlist(List<int>nums)
        {
            return nums.Where(n => n % 10 < 5).ToList();
        }
    }
}
