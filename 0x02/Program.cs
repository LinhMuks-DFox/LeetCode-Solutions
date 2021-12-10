using System;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

}
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode ret_dummy_head = new ListNode();
        int carry;

        while (l1 != null || l2 != null)
        {
            int n1 = l1 == null ? 0 : l1.val,
                n2 = l2 == null ? 0 : l2.val;

            if (l1 == null)
            {

            }

            if (l2 == null) 
            {

            }

            l1 = l1.next; l2 = l2.next;
        }

        return ret_dummy_head.next;
    }
}