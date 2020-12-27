/*
    Link: https://leetcode-cn.com/problems/integer-to-roman/
*/
using System.Text;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new Solution().IntToRoman(1994)); // MCMXCIV
    }
}

//DONE
class Solution
{

    public string IntToRoman(int num)
    {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        string ret = "";
        for (int i = 0; i < values.Length; ++i)
        {
            while (values[i] <= num)
            {
                num -= values[i];
                ret+= symbols[i];
            }
        }

        return ret;
    }
}