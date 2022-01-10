using System;

// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
// Input: head = [1, 1, 2, 3, 3]
// Output:[1,2,3]


public class RemoveDuplicateFromSortedList
{
    public ListNode RemoveDuplicates(ListNode head)
    {
        // avoid any null issues it is must
        if (head == null || head.next == null) return head;

        ListNode distinctList = head;

        // fast= 2*slow;
        while (distinctList != null && distinctList.next != null)
        {
            if (distinctList.val == distinctList.next.val)
            {
                distinctList.next = distinctList.next.next;
            }
            else
            {
                distinctList = distinctList.next;
            }
        }
        distinctList = null;
        return head;

    }

    public ListNode RemoveDuplicatesWithRecurssion(ListNode head)
    {

        if (head == null || head.next == null) return head;

        ListNode delNode = RemoveDuplicatesWithRecurssion(head.next);

        return delNode != null && delNode.val == head.val ? head.next.next : head.next;
    }
}
