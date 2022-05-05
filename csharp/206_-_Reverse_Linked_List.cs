/**
 * 206. Reverse Linked List - Easy
 * Given the head of a singly linked list, reverse the list, and return the reversed list.
 */

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
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        ListNode current = head;
        
        while (current != null) {
            ListNode next = current.next;
            
            current.next = previous;
            previous = current;
            current = next;
        }
        
        return previous;
    }
}