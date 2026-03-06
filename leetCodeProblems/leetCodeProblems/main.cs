namespace _1480_running_sum_of_1d_array_2;

public class main
{
    public static void Main()
    {
        //running Sum
        int[] testArray = {1,2,3,4};
        SolutionRunningSum solution = new SolutionRunningSum();
        int[] result = solution.RunningSum(testArray);
        foreach (var item in result)
        {
            //Console.WriteLine(item);
        }
        
        //ransom letter
        SolutionRansomNoteDict solutionRansomNoteDict = new SolutionRansomNoteDict();
        string ransomNote = "fihjjjjei";
        string magazine = "hjibagacbhadfaefdjaeaebgi";
        Console.WriteLine(solutionRansomNoteDict.CanConstruct(ransomNote, magazine));

    } 
}