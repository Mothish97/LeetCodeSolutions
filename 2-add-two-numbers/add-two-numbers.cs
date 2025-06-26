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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var carry = 0;
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        

        while(l1 != null || l2 != null ||carry != 0)
        {
            var l1val =  0;
            var l2val = 0;
            if(l1!= null)
            {
                l1val = l1.val;
                l1 = l1.next;
            }

            if(l2!= null)
            {
                l2val = l2.val;
                l2 = l2.next;
            }
            var total = l1val + l2val + carry;
            carry = total / 10;
            current.next = new ListNode(total % 10);
            current = current.next;

        }
        return dummy.next;
        
    }
}