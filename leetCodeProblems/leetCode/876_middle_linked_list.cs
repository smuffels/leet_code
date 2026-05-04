public class ListNode
{
    public ListNode next;
    public int val;

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
        var middle = head;
        var end = head;

        while (end != null && end.next != null)
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
        var size = 0;
        var current = head;

        while (current != null)
        {
            current = current.next;
            size++;
        }

        var middle = size / 2;

        current = head;
        for (var i = 0; i < middle; i++) current = current.next;

        return current;
    }
}