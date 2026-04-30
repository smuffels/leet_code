namespace _1480_running_sum_of_1d_array_2;

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

public class SolutionAddTwoNUmbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var resultNode = new ListNode();
        var current = resultNode;
        var carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry; // if null set value 0
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            //save directly into next. this way dont need to check if i need a next node. stops anyway when while is done
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return
            resultNode.next;
    }

    //the following solution only works if the numbers aren't too big for int or long
    /*
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var resultNode = new ListNode();
        var current = resultNode;
        var number_one = GetNUmber(l1);
        var number_two = GetNUmber(l2);

        int.TryParse(number_one, out var n1);
        int.TryParse(number_two, out var n2);

        var result = n1 + n2;

        var resultSrtring = reverseNumber(result);
        for (var i = 0; i < resultSrtring.Length; i++)
        {
            current.val = resultSrtring[i] - '0'; //char to int with ascii
            if (i != resultSrtring.Length - 1)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }

        return resultNode;
    }

    //inverting an int using string
    private string GetNUmber(ListNode node)
    {
        var invertedNumber = "";
        while (node != null)
        {
            invertedNumber = node.val + invertedNumber;
            node = node.next;
        }

        return invertedNumber;
    }

    private string reverseNumber(int number)
    {
        var invertedNumber = "";
        var stringNumber = number.ToString();
        foreach (var character in stringNumber) invertedNumber = character + invertedNumber;

        return invertedNumber;
    }
    */
}