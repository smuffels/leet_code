public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class SolutionMiddleLinkedList2
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode middle = head;
        ListNode end = head;

        while (end!= null  && end.next != null)
        {
            middle = middle.next;
            end = end.next.next;
        }

        return middle;
    }
}


public class SolutionMiddleLinkedList1
{
    public ListNode MiddleNode(ListNode head)
    {
        int size = 0;
        ListNode current = head;

        while (current != null)
        {
            current = current.next;
            size++;
        }

        int middle = size / 2;

        current = head;
        for (int i = 0; i < middle; i++)
        {
            current = current.next;
        }

        return current;
    }
}