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
    public ListNode MergeKLists(ListNode[] list) 
    {

        var lst = list.ToList();
        var res = new ListNode(0);
        var dummy = res;
        while(lst.Count >0)
        {
            var cur  = -1;
            var min= int.MaxValue;
            for(int i =0 ;i < lst.Count;i++)
            {   
                if(lst[i] != null)
                {
                    if(lst[i].val< min)
                    {
                        cur =i;
                        min = lst[i].val;
                    }
                }
            }
            if(min == int.MaxValue) return dummy.next;
            res.next = lst[cur];
            res = res.next;
            if(lst[cur].next == null)
            {
                lst.RemoveAt(cur);
            }
            else
            {
                lst[cur] = lst[cur].next;

            }
        }
        return dummy.next;

        
    }
}