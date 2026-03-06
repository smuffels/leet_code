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
        var number_one = GetNUmber(l1);
        var number_two = GetNUmber(l2);

        int.TryParse(number_one, out var n1);
        int.TryParse(number_two, out var n2);

        var result = n1 + n2;

        var resultSrtring = reverseNumber(result);
        foreach (var character in resultSrtring)
        {
            current.val = character - '0';
            if (character != resultSrtring[^1])
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

    //inverting an int with math. didn't work out bc in a case like 0101 it removed the leading zero 
    /*private static int ReverseDigits(int n)
    {
        var revNum = 0;
        while (n > 0)
        {
            revNum = revNum * 10 + n % 10;
            n = n / 10;
        }

        return revNum;
    }*/
}