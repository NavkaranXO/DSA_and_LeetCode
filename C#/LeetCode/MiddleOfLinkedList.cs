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
    public ListNode MiddleNode(ListNode head) {
       ListNode frontRunner = head;
       ListNode secondRunner = head;

       while(frontRunner!=null && frontRunner.next != null)
       {
            frontRunner = frontRunner.next.next;
            secondRunner = secondRunner.next;
       }

       return secondRunner; 
    }
}
