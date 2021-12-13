using System;

//https://leetcode.com/problems/middle-of-the-linked-list/submissions/
// Input: head = [1, 2, 3, 4, 5]
// Output:[5,4,3,2,1]


public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        // avoid any null issues it is must
        if (head == null || head.next == null) return head;

        ListNode current = head, prev = null;

        // fast= 2*slow;
        while (current != null)
        {
            ListNode fore = current.next;
            current.next = prev;
            prev = current;
            current = fore;
        }
        return prev;

    }
}
// fast pointer is moving 2 times slow pointer
// stop at list node (this will be odd length case) || stop at node after last which will be null (this is even length case)
// once fast reaches end slow will be at the middle node