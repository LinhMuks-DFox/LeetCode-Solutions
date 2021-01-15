/*
    Link:https://leetcode-cn.com/problems/container-with-most-water/
*/

using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

public class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0, j = height.Length - 1;
        int res = 0;
        while (i < j)
        {
            int area = Math.Min(height[i], height[j]) * (j - i);
            res = Math.Max(res, area);
            if (height[i] <= height[j])
            {
                ++i;
            }
            else
            {
                --j;
            }
        }

        return res;
    }
}
