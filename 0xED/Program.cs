using System;
/*
    Link: https://leetcode-cn.com/problems/delete-node-in-a-linked-list/
    这题有毒，先不写
    是谁杀了我，而我又杀了谁（笑）
*/

namespace _0xED
{
    public class LinkedNode
    {
        public int val { set; get; }
        public LinkedNode next { set; get; }

        public LinkedNode(int val)
        {
            this.val = val;
        }
    }

    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
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
