using Leetcode.Models;

namespace Leetcode.Tasks;

internal class MergeTwoListsTask
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        List<ListNode> result = new List<ListNode>(100);

        while (list1.next != null)
        {
            while (list2.next != null)
            {
                if (list2.val <= list1.val)
                {
                    result.Add(list2);
                    list2 = list2.next;
                }
                else
                {
                    break;
                }
            }
            result.Add(list1);
            list1 = list1.next;
        }

        return result.Any() ? result[0] : new ListNode();
    }
}