using System;

//https://leetcode.com/problems/middle-of-the-linked-list/submissions/
// Input: head = [1, 2, 3, 4, 5]
//               [4, 3, 2, 1, 0]
//k =3
// Output:2


public class GetKthElementFromLast
{
    public ListNode GetKth(ListNode head, int k)
    {
        // avoid any null issues it is must
        if (head == null || head.next == null) return -1;

        ListNode fast = head, slow = head;

        // fast= 2*slow;
        for (int i = 0; i < k; i++)
        {
            fast = fast.next;

        }

        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        return slow.data;
    }
}
// Move fast pointer  k times forwordr
// Move both fast and slow pointer until fast pointer is equal to tail or fast.next equal to null