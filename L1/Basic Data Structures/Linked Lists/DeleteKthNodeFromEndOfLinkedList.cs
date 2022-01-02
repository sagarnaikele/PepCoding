using System;

// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// Input: head = [1, 2, 3, 4, 5], n = 2
// Output:[1,2,3,5]

public class DeleteKthNodeFromEndOfLinkedList
{
    public ListNode RemoveKthNode(ListNode head, int kth)
    {
        // avoid any null issues it is must
        if (head == null || kth <= 0)
        {
            return head;
        }

        ListNode dummy = new ListNode(-1);
        ListNode.next = head;
        ListNode slow = dummy, fast = dummy;

        for (int i = 1; i <= kth; i++)
        {
            fast = fast.next;
        }

        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next; // at this point slow will be just before the node we want to delete

        return dummy.next;

    }
}
// Create dummy node whoes next is head and Maintain slow and fast pointer for maintaining gap,
// Run fast pointer by gap then simply run both slow and fast pointer 
// Once loop is over Node slow nodes next will be pointing to kth node from last
