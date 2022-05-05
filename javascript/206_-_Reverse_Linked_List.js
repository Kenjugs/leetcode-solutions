/**
 * 206. Reverse Linked List - Easy
 * Given the head of a singly linked list, reverse the list, and return the reversed list.
 */

/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseList = function(head) {
    let previous = null;
    let current = head;
    
    while (current) {
        const next = current.next;
        
        current.next = previous;
        previous = current;
        current = next;
    }
    
    return previous;
};