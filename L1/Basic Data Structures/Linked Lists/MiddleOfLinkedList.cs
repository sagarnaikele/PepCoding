using System;

//https://leetcode.com/problems/middle-of-the-linked-list/submissions/
// Input: head = [1, 2, 3, 4, 5]
// Output:[3,4,5]
// Explanation: The middle node of the list is node 3.

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        // avoid any null issues it is must
        if (head == null || head.next == null) return head;

        ListNode slow = head, fast = head;

        // fast= 2*slow;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;

    }
}
//fast pointer is moving 2 times slow pointer
// stop at list node (this will be odd length case) || stop at node after last which will be null (this is even length case)
// once fast reaches end slow will be at the middle node