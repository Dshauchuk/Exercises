using Leetcode.Models;

namespace Leetcode.Tasks;
// Linked List Cycle II
internal class DetectCycleTask
{
    public ListNode? DetectCycle(ListNode head)
    {
        HashSet<ListNode> visits = new HashSet<ListNode>();

        while (head != null && head.next != null)
        {
            if (visits.Contains(head))
                return head;

            visits.Add(head);
            head = head.next;
        }

        return null;
    }
}