// O(n) time Complexity

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {

        if(head == null) 
        {
            return false;
        }

        if(head.next == null)
        {
            return false;
        }
        
        Hashtable visitedNodes = new Hashtable();
        ListNode node = head;

        while(node.next != null) {
            
            if (visitedNodes.Contains(node))
            {
                return true;
            }

            visitedNodes.Add(node, node.val);

            node = node.next;

        }

        return false;
}
}
