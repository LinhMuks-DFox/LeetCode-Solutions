using System;
using System.Collections.Generic;
/*
    Link: https://leetcode-cn.com/problems/valid-parentheses/
*/
namespace _0x14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsValid("(){}}{"));
        }
    }
    /*Tested! Done! but not fast!*/
    class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
                return false;
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> map = new Dictionary<char, char>();
            map['}'] = '{'; map[')'] = '('; map[']'] = '[';
            foreach (char cur in s)
            {
                if (map.ContainsKey(cur))
                {
                    if (stack.Count == 0 || stack.Pop() != map[cur])
                        return false;
                }
                else
                    stack.Push(cur);
            }

            return stack.Count == 0;
        }
    }
}
