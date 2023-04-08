using Leetcode.Models;

namespace Leetcode.Tasks;

// 328. Odd Even Linked List
internal class OddEventListTask
{
    public ListNode? OddEvenList(ListNode? head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode oddLast = head, evenLast = head.next, eventHead = head.next, oddHead = head;

        head = head.next.next;
        int index = 3;
        bool oddHeadInitialized = false, evenHeadInitialized = false;

        while (head != null)
        {
            if (index % 2 == 0)
            {
                evenLast.next = head;
                evenLast = evenLast.next;

                if (!evenHeadInitialized)
                {
                    eventHead.next = evenLast;
                    evenHeadInitialized = true;
                }
            }
            else
            {
                oddLast.next = head;
                oddLast = oddLast.next;

                if (!oddHeadInitialized)
                {
                    oddHead.next = oddLast;
                    oddHeadInitialized = true;
                }
            }

            index++;
            head = head.next;
        }

        evenLast.next = null;
        oddLast.next = eventHead;

        return oddHead;
    }
}