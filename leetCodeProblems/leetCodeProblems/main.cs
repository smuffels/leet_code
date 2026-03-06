namespace _1480_running_sum_of_1d_array_2;

public class main
{
    public static void Main()
    {
        //running Sum
        int[] testArray = { 1, 2, 3, 4 };
        var solution = new SolutionRunningSum();
        var result = solution.RunningSum(testArray);
        foreach (var item in result)
        {
            //Console.WriteLine(item);
        }

        //ransom letter
        var solutionRansomNoteDict = new SolutionRansomNoteDict();
        var ransomNote = "fihjjjjei";
        var magazine = "hjibagacbhadfaefdjaeaebgi";
        //Console.WriteLine(solutionRansomNoteDict.CanConstruct(ransomNote, magazine));

        //add two numbers
        var solutionAddTwoNUmbers = new SolutionAddTwoNUmbers();
        var node1 = new ListNode(5, new ListNode(6));
        var node2 = new ListNode(5, new ListNode(4, new ListNode(9)));
        var resultAddition = solutionAddTwoNUmbers.AddTwoNumbers(node1, node2);
        var node = resultAddition;
        while (node != null)
        {
            Console.Write(node.val + " ");
            node = node.next;
        }
    }
}