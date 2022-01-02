using System;


public static class MergekSortedLists
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            return null;
        }
        return Merge(lists, 0, lists.Length - 1);
    }

    public ListNode Merge(ListNode[] list, int start, int end)
    {
        if (start == end) return list[start];

        int mid = start + ((end - start) / 2);

        ListNode left = Merge(list, start, mid);
        ListNode right = Merge(list, mid + 1, end);

        return MergeTwoSortedList(left, right);

    }

    public ListNode MergeTwoSortedList(ListNode l1, ListNode l2)
    {
        if (l1 == null || l2 == null)
        {
            return l1 == null ? l2 : l1;
        }

        ListNode dummy = new ListNode(-1);
        ListNode left = l1, right = l2, res = dummy;

        while (left != null && right != null)
        {
            if (left.val < right.val)
            {
                res.next = left;
                left = left.next;
            }
            else
            {
                res.next = right;
                right = right.next;
            }
            res = res.next;
        }

        res.next = left != null ? left : right;
        ListNode head = dummy.next;
        dummy.next = null;
        return head;

    }
}
