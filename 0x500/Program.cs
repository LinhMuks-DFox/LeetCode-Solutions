using System;
/*
    Link: https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
*/

namespace _0x500
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            int res = 0;
            while (head != null)
            {
                res <<= 1;
                res |= head.val;
                head = head.next;
            }
            return res;
        }
    }

    public class LinkedNode
    {
        public int val { set; get; }
        public LinkedNode next { set; get; }

        public LinkedNode(int val)
        {
            this.val = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
