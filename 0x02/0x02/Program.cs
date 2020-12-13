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

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }

}
public class Solution {
    public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
        ListNode dummy_head = new ListNode ();
        bool is_shift = false;
        ListNode cur = dummy_head.next;
        while (l1 != null && l2 != null) {
            if(is_shift)
                int v = l1.val  + ls2.val + 1;
            if(cur == null){
                cur = new ListNode(v);
            }else{
                cur.val = v;
            }

            cur = cur.next; l1 = l1.next; l2=l2.next;

        }
    }
}