using System;

//https://leetcode.com/problems/merge-two-sorted-lists/
// Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
// Output:[1,1,2,3,4,4]

public class MergeTwoSortedList
{
    public ListNode Merge(ListNode list1, ListNode list2)
    {
        // avoid any null issues it is must
        if (head == null || head.next == null) return list1 == null ? list2 : list1;

        ListNode left = list1, right = list2, dummy = new ListNode(), prev = dummy;

        while (left != null && right != null)
        {

            if (left.val < right.val)
            {
                prev.next = left;
                left = left.next;
            }
            else
            {
                prev.next = right;
                right = right.next;
            }
            prev = prev.next;
        }


        prev.next = left == null ? right : left;
        ListNode head = dummy.next;
        dummy.next = null; // break link of old list for security
        return head;

    }
}
// Maintain left and right pointer for both sorted list for further computation,
// create dummy and previous node so that new sorted list will be created
// check the smallest value node and move "prev" pointer to that node and increment both the node
// finally check if any list is having some element, 
// if yes simply join that list to "prev" list by pointing prev.next to that list
// decide head which willl be next node off dummy node and 
// finally break linking of all other unsued link for security reason