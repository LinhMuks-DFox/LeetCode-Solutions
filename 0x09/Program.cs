using System;

namespace _0x09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int cur = 0;
            while (x != cur)
            {
                cur = cur * 10 + x % 10;
                x /= 10;
            }

            return x == cur || x == cur / 10;
        }
    }
}